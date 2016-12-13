using System;
using System.Collections.Generic;
using System.Linq;

using PersonMatcher.Patterns;
using PersonMatcher.Persons;
using PersonMatcher.IO;

namespace PersonMatcher
{
    public class MatchMaker
    {
        public MatchMaker()
        {
            Matches = new List<MatchResult>();
            Persons = new List<Person>();
            MatchingPatterns = MatchingPatternFactory.GetSortedPatterns();
        }

        public bool LoadPersonsFromFile(String filename, FileHandler.FileType fileType)
        {
            FileHandler inputFileHandler = FileHandlerFactory.GetFileHandler(fileType);
            Persons = inputFileHandler.Load(filename);
            return Persons != null;
        }

        public List<MatchResult> FindMatchesFromFile(String filename, FileHandler.FileType fileType)
        {
            FileHandler inputFileHandler = FileHandlerFactory.GetFileHandler(fileType);
            Persons = inputFileHandler.Load(filename);
            if (Persons != null)
            {
                Matches = FindAllMatches();
            }
            Logger.Info($"Found {Matches.Count} matches");
            return Matches;
        }

        public bool SaveMatchesToFile(String filename, FileHandler.FileType fileType)
        {
            FileHandler outputFileHandler = FileHandlerFactory.GetFileHandler(fileType);
            if (Matches.Count > 0)
            {
                return outputFileHandler.Save(filename, Matches);
            }
            else
            {
                Logger.Warn("No matches available to export");
                return false;
            }
        }

        public List<MatchResult> FindAllMatches(List<Person> personList = null)
        {
            Matches.Clear();

            if (personList == null && Persons == null)
            {
                return new List<MatchResult>();
            }
            else if (personList == null && Persons != null)
            {
                personList = Persons;
            }

            for (int i = 0; i < personList.Count(); i++)
            {
                for (int j = i + 1; j < personList.Count(); j++)
                {
                    int equalsFound = 0;
                    int inequalsFound = 0;

                    foreach (BasePattern pattern in MatchingPatterns)
                    {
                        BasePattern.MATCH_RESULT result = pattern.Compare(personList[i], personList[j]);
                        if (result == BasePattern.MATCH_RESULT.NOT_EQUAL)
                        {
                            inequalsFound++;
                            break;
                        }
                        else if (result == BasePattern.MATCH_RESULT.EQUAL)
                        {
                            equalsFound++;
                        }
                    }

                    if (inequalsFound == 0 && equalsFound > 0)
                    {
                        MatchResult newMatch = new MatchResult(personList[i], personList[j]);
                        Logger.Info($"New Match! -> {newMatch.ToString()}");
                        Matches.Add(newMatch);
                        OnMatchFound?.Invoke(newMatch);
                    }
                }
            }

            return Matches;
        }

        public delegate void MatchEvent(MatchResult result);
        public event MatchEvent OnMatchFound;
        public List<Person> Persons { get; set; }
        public List<MatchResult> Matches { get; set; }
        protected List<BasePattern> MatchingPatterns { get; set; }
        private static LogUtility Logger = new LogUtility("Matcher Worker");
    }
}
