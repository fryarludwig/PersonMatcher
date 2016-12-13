
# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
#                   Kenny Fryar-Ludwig                    #
#                   CS5700: Homework 5                    #
#         Refactoring Homework 1 - Person Matcher         #
# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #

# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
Design Review for Original Homework 1 Implementation:
  Overview:
    1. Weak unit testing with minimal coverage
    2. Presence of several bugs limiting functionality
    3. Poor implementation due to inexperience with C#
    4. Near complete absence of design documentation
  Pitfalls:
    1. Uncommutative names
    2. Dead Code
    3. Embedded types in names
    4. Duplicate code
    5. Speculative Generality
    6. Temporary field
# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #

# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
Additional design patterns added during HW5:
    1. Observer Pattern [ newly added ]
        - Allow more responsive GUI
        - Reduce coupling
        - Improve extensibility
    2. Simple Factory Pattern [ significantly improved ]
        - Used to instantiate proper file handler
        - Reduced scope, complexity, and speculative generality

# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
System Functionality:
    1. Expanded "matches" to show the algorithms' decision processes
        This allows users to manually inspect and determine the accuracy
        of the algorithms used to make the decisions. This part is actually
        pretty cool and you should look at it.

    2. Users can filter log messages based on severity, or "Level"
        Previously, a large amount of log messages reduced the responsiveness
        of the GUI while burying warnings and errors among "info" and "trace"
        messages.

    3. Stability and responsiveness have been improved
        Using the Subscriber/Observer pattern for GUI updates and logging,
        the user experience is significantly improved.
# # # # # # # # # # # # # # # # # # # # # # # # # # # # # #


6. Redo your design document (Interaction, and State Chart diagrams)

8. Test non-GUI components thoroughly

9. Write up a short summary (less than 1 page) in a README file that explains your improvements andenhancements, plus your rationale.
