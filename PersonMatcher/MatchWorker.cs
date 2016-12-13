using System;
using System.Collections.Generic;
using System.Linq;

using PersonMatcher.Patterns;
using PersonMatcher.Persons;
using PersonMatcher.IO;

namespace PersonMatcher
{
    public class MatchWorker
    {
        public List<MatchResult> FindMatchesFromFile(String filename, FileHandler.FileType fileType)
        {
            FileHandler inputFileHandler = FileHandlerFactory.GetFileHandler(fileType);
            List<Persons.Person> personList = inputFileHandler.ParseFile(filename);

            if (personList != null)
            {
                for (int i = 0; i < personList.Count; i++)
                {
                    Logger.Info(personList[i].FirstName);
                }
            }

            List<MatchResult> matchList = FindAllMatches(personList);

            if (matchList != null)
            {
                for (int i = 0; i < matchList.Count; i++)
                {
                    Logger.Info(matchList[i].ToString());
                }
            }

            Logger.Info($"Found {matchList.Count} matches");
            return matchList;
        }

        public List<MatchResult> FindAllMatches(List<Person> personList)
        {

            if (personList == null)
            {
                Logger.Warn("Empty person list provided, no matches can be made");
                return new List<MatchResult>();
            }

            List<MatchResult> matchList = new List<MatchResult>();
            List<MatchingPattern> patternList = MatchingPatternFactory.GetSortedPatterns();

            for (int i = 0; i < personList.Count(); i++)
            {
                for (int j = i + 1; j < personList.Count(); j++)
                {
                    MatchingPattern.MATCH_RESULT result = MatchingPattern.MATCH_RESULT.INCONCLUSIVE;
                    int patternIndex = 0;
                    while (patternIndex < patternList.Count && result == MatchingPattern.MATCH_RESULT.INCONCLUSIVE)
                    {
                        Logger.Info($"Pattern {patternList[patternIndex].PatternName} is being tried");
                        result = patternList[patternIndex++].CheckMatch(personList[i], personList[j]);
                    }

                    if (result == MatchingPattern.MATCH_RESULT.EQUAL)
                    {
                        MatchResult newMatch = new MatchResult(personList[i], personList[j]);
                        Logger.Info($"New Match! -> {newMatch.ToString()}");
                        matchList.Add(newMatch);
                    }
                }
            }
            
            return matchList;
        }

        private static LogUtility Logger = new LogUtility("Matcher Worker");
    }
}
