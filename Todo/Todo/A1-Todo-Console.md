# Assignment 1: To-do List Console App

**Deadline: September 11, 2014, 11:59pm, US Central**

## Tasks

In this first assignment, you are to develop a simple console app to manage
a list of things to do; it is similar to the TodoMVC webapp at: 
http://todomvc.com.

That is, the *Todo* app *manages* a list of *entries*. Each entry consists of
a textual *description* and a *status* of either *active* or *completed*.
The app provides several *operations* to:
(1) *add* a new entry,
(2) to *edit* the description of previously entered entry,
(3) to *toggle* the active/completed status of an entry, 
(4) *delete* an entry, and
(5) *delete* completed entries.
In addition, it can -- (6) *change* the app list *display mode* to display: 
(1) all entries, (2) only active entries, or (3) only completed entries.

Since this is a console app, it is menu-based instead of the interactive UI of
TodoMVC.
The menu system is best described using a running demo of the app input/output
below (when the app is started, it displays an empty todo list, and :

```
To Do
=====
No entry to display

No active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 1
Enter description (empty to cancel): Clone GitHub repo https://github.com/ksucis-501/coursework.git

To Do
=====
1. Clone GitHub repo https://github.com/ksucis-501/coursework.git

1 active entry

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 1
Enter description (empty to cancel): Download zip file for Assignment 1

To Do
=====
1. Clone GitHub repo https://github.com/ksucis-501/coursework.git
2. Download zip file for Assignment 1

2 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 1
Enter description (empty to cancel): Uncompress the downloaded zip file and move it into the local coursework Git repo

To Do
=====
1. Clone GitHub repo https://github.com/ksucis-501/coursework.git
2. Download zip file for Assignment 1
3. Uncompress the downloaded zip file and move it into the local coursework Git repo

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 1
Enter description (empty to cancel): Commit and push the assignment

To Do
=====
1. Clone GitHub repo https://github.com/ksucis-501/coursework.git
2. Download zip file for Assignment 1
3. Uncompress the downloaded zip file and move it into the local coursework Git repo
4. Commit and push the assignment

4 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 1
Enter description (empty to cancel): Work on the assigment and commit & push; rinse and repeat

To Do
=====
1. Clone GitHub repo https://github.com/ksucis-501/coursework.git
2. Download zip file for Assignment 1
3. Uncompress the downloaded zip file and move it into the local coursework Git repo
4. Commit and push the assignment
5. Work on the assigment and commit & push; rinse and repeat

5 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 2
Enter entry number to edit (1..5; 0 to cancel): 1
Enter a new description (empty to cancel):  Clone GitHub repo https://github.com/ksu-cis-501/<username>-coursework.git

To Do
=====
1. Clone GitHub repo https://github.com/ksu-cis-501/<username>-coursework.git
2. Download zip file for Assignment 1
3. Uncompress the downloaded zip file and move it into the local coursework Git repo
4. Commit and push the assignment
5. Work on the assigment and commit & push; rinse and repeat

5 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 3
Enter entry number to toggle (1..5; 0 to cancel): 1

To Do
=====
1. Clone GitHub repo https://github.com/ksu-cis-501/<username>-coursework.git (completed)
2. Download zip file for Assignment 1
3. Uncompress the downloaded zip file and move it into the local coursework Git repo
4. Commit and push the assignment
5. Work on the assigment and commit & push; rinse and repeat

4 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 3
Enter entry number to toggle (1..5; 0 to cancel): 2

To Do
=====
1. Clone GitHub repo https://github.com/ksu-cis-501/<username>-coursework.git (completed)
2. Download zip file for Assignment 1 (completed)
3. Uncompress the downloaded zip file and move it into the local coursework Git repo
4. Commit and push the assignment
5. Work on the assigment and commit & push; rinse and repeat

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 4
Enter entry number to delete (1..5; 0 to cancel): 1

To Do
=====
1. Download zip file for Assignment 1 (completed)
2. Uncompress the downloaded zip file and move it into the local coursework Git repo
3. Commit and push the assignment
4. Work on the assigment and commit & push; rinse and repeat

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 6

View Mode
---------
1. Show all entries
2. Show active entries only
3. Show completed entries only

Enter selection (1..3): 1

To Do
=====
1. Download zip file for Assignment 1 (completed)
2. Uncompress the downloaded zip file and move it into the local coursework Git repo
3. Commit and push the assignment
4. Work on the assigment and commit & push; rinse and repeat

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 6

View Mode
---------
1. Show all entries
2. Show active entries only
3. Show completed entries only

Enter selection (1..3): 2

Active Entries
==============
1. Uncompress the downloaded zip file and move it into the local coursework Git repo
2. Commit and push the assignment
3. Work on the assigment and commit & push; rinse and repeat

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 6

View Mode
---------
1. Show all entries
2. Show active entries only
3. Show completed entries only

Enter selection (1..3): 3

Completed Entries
=================
1. Download zip file for Assignment 1

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 5
Are you sure you want to delete all completed entries (type 'yes' to confirm)? yes

Completed Entries
=================
No entry to display

3 active entries

Menu
----
1. Add Entry
2. Edit Entry Description
3. Toggle Entry Status
4. Delete Entry
5. Delete Completed Entries
6. Set View Mode
7. Exit

Enter selection (1..7): 7

Good bye!
```

Your tasks for this assignments are to:

1. implement the above menu-based Todo console app.

   **Important**: You should put comments at each class and method, even a group
   of statements to help us understand your implementation (see 
   the ``TodoConsoleTest.test`` method for example). 

2. develop automated app tests that reach **100%** coverage of the app code; 
   see the course notes on
   [(console) app testing](http://softwarearch.santoslab.org/01-tooling/index.html#app-testing)
   (the tests for the course note prime tool example reach 100% coverage).
   For most tests, you should have the expected output similar to the prime tool
   tests; note that you should be careful with white-spaces when entering 
   your expected output.
   You can first run the tests without an expected output (e.g., ``null``),
   once you inspect the output manually, you can copy and paste the test output
   to become the expected output.
   The tests are useful for detecting regression in your code when you modify
   the code later on (this is called *regression testing*).

**Important**: for each operation and sub-operation, you should define one test.
For example, based on the menu system illustrated above, there should be 1 test
defined to exercise adding a new entry; in addition, the app allows user
to cancel entry addition by entering an "empty" input for the entry description,
thus, 1 test should be defined to illustrate this scenario.
Note that your max score for this assignment is capped by the amount of test
coverage that you achieve. 
That is, if the assignment is worth 10 points and your tests cover only, for
example, 80% coverage, then, your max score is 8 out of 10.
The model solution achieves 100% coverage using 15 test scripts (and those
are not the minimal set); this gives an idea on the amount of efforts that you
should expect to spend.

The provided Visual Studio solution consists of two projects: 
(1) ``Todo-Console``, and (2) ``Todo-Console-Tests`` as starting point for 
the two tasks above (respectively).

**Note:** If you have specific programming questions, we are happy to answer 
them. However, try Googling or searching for answers at 
http://stackoverflow.com,  
http://msdn.microsoft.com, and
http://www.dotnetperls.com first because it is highly likely that people have 
asked similar questions in the past.
This helps you to make progress without waiting for us to respond to your 
questions (or even waiting to set up an appointment first).
If you send us a question, we will actually try Googling your question first
and see if it turns out with some acceptable answers that we believe you should
understand; if so, we will send you the links (and then setup an appointment 
if you still need more help).
This is how people in the industry (and the instructor) work with their peers
(i.e., by leveraging online resources for self-learning first and then resort
to asking for help from colleagues).
   

## Submission

To submit, copy the folder containing this file to your local GitHub repository
for the course, and then commit and push your modified solutions to GitHub 
by the deadline
(see the  
[course note on Git/GitHub](http://softwarearch.santoslab.org/01-tooling/index.html#git-github)).
