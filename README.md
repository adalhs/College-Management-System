# College-Management-System

***To use program, run the ProyectoFinal.sln file.  You will need Visual Studio with .NET Desktop Development workload installed.***<br/><br/>


## 1. PURPOSE OF THE SYSTEM

The InterMetro Information System was developed as my capstone project to obtain my BSc in Computer Science at the Interamerican University of Puerto Rico.  The system's purpose is to facilitate the process of student data management at the Interamerican University of Puerto Rico Metropolitan Campus by the employees of the enrollment offices, in particular the admissions and registrar's offices.  The system will allow employees of the enrollment offices, faculty members, students, and system/account administrators access to specific portals where they will be able to access and/or modify data relevant to them through their accounts.  An account must be created through the system administrator portal for each employee, faculty member, or student that is enrolled in the system so they can access their respective portal.

For demonstration purposes, the system database (hosted in Azure SQL Server) already contains several records with accounts to be used with this application.  The usernames and passwords for these can be found in their respective portal section of this readme file, maked by a "**" symbol.  Feel free to use the system to add more records or edit existing ones if you want to test things out, and use the system as you wish.  The admissions office portal can be used to create a new record by entering the required user information, and the system/account administrator portal can be used to give that record a username, password, and access permissions.<br/><br/><br/>


## 2. SYSTEM ACCESS CONTROL

In order to access the InterMetro Information System, the user must enter their username and password on the system's home page.  According to the access permissions granted by the system administrator to the user's account at the time it is created, the user will be able to access the corresponding portal within the system.

<img src="https://user-images.githubusercontent.com/104173074/185225705-1ffcae21-f079-430b-9343-2517a6845aa5.png" height="65%" width="65%" ><br/><br/><br/>


## 3. ADMISSIONS OFFICE PORTAL

****User: Camila Puentes / Username: camilaadmissions / Password: adminadmissions**

In the admissions portal you may enter the personal information of the institution's students, as well as search for a particular student's information and edit that information. When entering information for a new student, the system automatically generates an identification number starting with the letter M (for metropolitan campus) followed by eight random numbers.<br/><br/>

### - Entering new student information

To enter the information of a new student, you must go to the Student Information Management page in the portal of the admissions office and click on the “Add New” button to open the information boxes.

<img src="https://user-images.githubusercontent.com/104173074/185252231-8b79957e-8f84-4aec-82bf-cfbf5406a66d.png" height="65%" width="65%" >

After entering the student information, click on the “Submit” button. There are information fields that are required. If any of these are left blank, the system will not allow you to continue. The “Yearly Household Income” field is not required, however, it is necessary if the student wishes to apply for financial aid. By clicking on “Submit”, the system will show the information entered for the student to verify that it is correct, and if so, the user information is entered and an identification number is automatically created for the student.<br/>

<img src="https://user-images.githubusercontent.com/104173074/185252858-a11fff1a-22d2-43f3-b90d-a7959eb90527.png" height="70%" width="70%" ><br/><br/>

### - Searching and updating student information

To search for a student's information, click the “Search” button, enter the student's ID number, and press OK.

<img src="https://user-images.githubusercontent.com/104173074/185253490-809a14c4-5a71-43da-9702-251fa0a57e31.png" height="30%" width="30%" >

Student information will be loaded into the blanks on the form.

<img src="https://user-images.githubusercontent.com/104173074/185256159-047afbca-d696-4c8e-aa91-86fab62f6fc6.png" height="65%" width="65%" >

If you would like to change any information, you must edit the corresponding information in the form and then click on the “Update” button to save the new information. If you change the information in the blanks but do not click on the "Update" button, the changes made will not be saved.<br/><br/><br/>


## 4. SYSTEM/ACCOUNT ADMINISTRATOR PORTAL

****User: Adalberto Holguin / Username: admin / Password: admin**

The system administrator portal allows the admin to create the user accounts that will use the InterMetro Information System as well as manage the access permissions of the accounts and delete accounts. To create a user's account, the user must have already obtained their identification number by adding their personal information in the admissions office portal, since the identification number will be used during the account creation process to link the created account to each user.<br/><br/>

### - Creating accounts

To create an account, you must go to the Account Management page within the System Administrator Portal and click on the “Add New User” button. A field will appear to enter the user identification number.

<img src="https://user-images.githubusercontent.com/104173074/185258175-22c341b3-49b7-49b8-ac90-4ee4439a5153.png" height="70%" width="70%" >

After entering the identification number, the user enters his username and desired password and the administrator will choose the access permission to give to the account. To finish the account creation process, press the “Submit” button.

<img src="https://user-images.githubusercontent.com/104173074/185259747-f202a293-5a38-438b-8ebe-dd67932b35ae.png" height="30%" width="30%" ><br/><br/>

### - Deleting accounts

To delete an account, click on the “Delete Account” button and enter the username of the account you want to delete.

<img src="https://user-images.githubusercontent.com/104173074/185260310-4a7b4113-aa39-41ef-9c08-ecd7f616069a.png" height="70%" width="70%" >

Before deleting the user's account, a message will be presented to the administrator confirming that they want to delete the account. If an account is deleted by mistake, this is not something serious, since in the InterMetro Information System, no information or data of the employee or student is linked to their access account, but to their identification number. The access accounts only regulate which portal the user can enter, so if an account is deleted by mistake, the admin can simply create another account for that user by entering their identification number, this is also a way to change the user's username and password.<br/><br/>

### - Changing an account's access permission

To change the access permissions of an account, click on the “Change User Permissions” button and enter the user identification number. Then choose the desired access permission from the drop-down menu and click the "Update" button.<br/><br/>

### - Note on modifying or deleting administrator accounts

An account belonging to a system/account administrator cannot be modified or deleted using this system. This is because if there is only one administrator account in the system, and its admin permissions are changed, or the account is deleted, there will be no other account that can access the administrator's portal and no user that can give an account administrator privileges.  To avoid this situation, the functionality of modifying or deleting administrator accounts can only be done by contacting customer support.<br/><br/><br/>


## 5. REGISTRAR'S OFFICE PORTAL

****User: Carlos Ocasio / Username: carlosregistrar / Password: adminregistrar**

In the registrar's office portal, you can access the Student Records Management System to enroll students in different courses, drop them from courses, verify the courses enrolled, and change the student's concentration.<br><br/>

### - Opening and closing student records

To open a student's record, click the “Open Record” button, which will bring up a box to enter the student's identification number.

<img src="https://user-images.githubusercontent.com/104173074/185264489-994161b0-fe08-444b-a5b5-20c90fe6f6d0.png" height="70%" width="70%" >

To close the student's record, click on the "Close Record" button.<br/><br/>

### - Enrolling courses

To enroll a student in a course, you must first open the student's record using their identification number. After this, you must click on the “Add Course” button and enter the section number desired by the student and press OK.  In a traditional setting, the student would fill out a form containing the course section number and had it to the registrar, but for purposes of this demonstration, the following table with the courses and course sections in the system is given:

|   Section ID  |  Course Code  |        Course Name        |    Assigned Instructor    |       Major      | Prerequisite |
| ------------- | ------------- | ------------------------- | ------------------------- | ---------------- | ------------ |
|     32092     |   COMP 2120   |    Logical Programming    |       Maria De Jesus      | Computer Science |              |
|     32111     |   CHEM 2320   |       Food Chemistry      |      Belinda Rosario      |     Chemistry    |              |
|     34298     |   COMP 2310   |   Structured Programming  |       Maria De Jesus      | Computer Science |              |
|     34416     |   COMP 3412   |     Data Structures II    |     Jonathan Brickman     | Computer Science |   COMP 3411  |
|     34872     |   CHEM 2220   |    Analytical Chemistry   |      Belinda Rosario      |     Chemistry    |              |
|     38522     |   CHEM 3311   |    Organic Chemistry I    |       Charles Conroy      |     Chemistry    |              |
|     41066     |   CHEM 2410   |      Green Chemistry      |       Charles Conroy      |     Chemistry    |              |
|     42862     |   COMP 2400   |Object Oriented Programming|     Jonathan Brickman     | Computer Science |              |
|     44412     |   COMP 3411   |     Data Structures I     |     Jonathan Brickman     | Computer Science |              |
|     44529     |   COMP 2025   |      Web Page Design      |       Maria De Jesus      | Computer Science |              |
|     45162     |   CHEM 3312   |    Organic Chemistry II   |       Charles Conroy      |     Chemistry    |   CHEM 3311  |
|     46182     |   CHEM 2210   |     General Chemistry     |      Belinda Rosario      |     Chemistry    |              |

The system will automatically verify that the student has completed any prerequisite course before enrolling in the course, as well as that the course being attempted belongs to the student's concentration.  If the student meets the requirements of the course, the system will present a window with the information of the name and code of the course, days, hours, and place of the meetings, as well as the instructor assigned to the course to verify that the information is correct before adding the course.  A student may enroll in up to four courses per term.<br/><br/>

### - Dropping courses

To drop a student from a course, click on the “Drop Course” button, then go to the “Enrolled Courses” list, choose the course you want to drop, and press the "Submit" button.

<img src="https://user-images.githubusercontent.com/104173074/185283491-8d92c3f4-f1ff-4d03-b6b1-a79b9da6fe27.png" height="50%" width="50%" >

Dropping a course is an IRREVERSIBLE process that will remove any grades the student has received in the course up to that point. You must be sure that this is what you want to do before proceeding with this step.<br/><br/>

### - Changing student's concentration

To change a student's major, click the "Change Major" button and choose a new major from the drop-down "Major" list, then press the Submit button.  For demonstration purposes, only two majors have been added to the system.

<img src="https://user-images.githubusercontent.com/104173074/185286604-2526690b-a0e7-47c6-87dd-ffd27359e375.png" height="50%" width="50%" ><br/><br/><br/>

## 6 - FACULTY PORTAL

****User: Maria De Jesus / Username: mariafaculty / Password: adminfaculty**

****User: Charles Conroy / Username: charlesfaculty / Password: adminfaculty**

****User: Jonathan Brickman / Username: jonathanfaculty / Password: adminfaculty**

****User: Belinda Rosario / Username: belindafaculty / Password: adminfaculty**

This portal will allow faculty members (professors) to manage the grades of students enrolled in courses assigned to each instructor through the Grade Detail Management page. Here you can assign grades to students, as well as drop them from a course if necessary.<br/><br/>

### - Loading a section

The first thing an instructor needs to do before they can assign grades to students in their courses is to load a section of a course that has been assigned to them. Instructors will access the Grade Detail Management page where a drop-list with all the courses assigned to them will appear.  They will choose a course from the list and click the “Load Section” button to load the section and display a list of all students enrolled in that section in the Enrolled Students drop-down list.

<div>
<img src="https://user-images.githubusercontent.com/104173074/185288456-6f36fe6b-d4f0-4d34-ae75-d87fa2b1a4af.png" height="30%" width="30%" >
<img src="https://user-images.githubusercontent.com/104173074/185288995-3e01b8f5-fceb-4d39-bfaa-12901a290bbc.png" height="60%" width="60%" >
</div><br/><br/>

### - Assigning grades

To assign student grades, load the corresponding section, choose the desired student from the “Enrolled Students” drop-down list and click on the “Load Student Grade Detail" button.  The student's grades for that course's section will appear under the “Grade Detail” list. From here, the instructor can choose the grade they wish to assign to the student and click the “Enter Grade” button to enter the student's grade.

<div>
<img src="https://user-images.githubusercontent.com/104173074/185290311-64b3f35f-b878-4398-9e05-37974fe4c23c.png" height="40%" width="40%" >
<img src="https://user-images.githubusercontent.com/104173074/185290329-05f8401b-0a6a-4b9d-868c-ffd342d66fb2.png" height="40%" width="40%" >
</div>

If the instructor wants to change a grade they have already assigned, they can choose the desired grade from the “Grade Detail” drop-down list and click the “Enter Grade” button again. This time, the system will ask the instructor if they want to change the grade they have already entered. To edit the grade, click “Yes” and enter the new desired score.<br/><br/>

### - Assigning a final grade

To assign the final grade of the course to a student, the student's grade detail must be loaded by clicking the “Load Student Grade Detail” button and clicking on the “Final Grade” button. The system will automatically calculate the student's percentage and final grade according to the entered grade scores. Similarly, the new grade is added to the student's GPA and this is automatically adjusted according to the credits of the completed course and the student's total of completed credits.

<img src="https://user-images.githubusercontent.com/104173074/185296057-d8a65ff1-d38e-4c7a-aee8-201c272c6795.png" height="70%" width="70%" >

After having assigned a final grade to the student, it cannot be changed, so you must be sure that you want to continue with this step. The system will still allow the instructor to change the course grades, however this will have no effect as the final grade can only be calculated once.<br/><br/>

### - Dropping a student from a course

Professors can also drop students from courses if the students cannot fulfill the criteria to obtain their midterm grades.  To drop a student from a course (assign AW), you must access the student's grade detail by clicking on the “Load Student Grade Detail” button then clicking on the “Enter AW” button. Dropping a student from a course is an IRREVERSIBLE process, and for security reasons, the system will give a warning to the instructor, and ask him to enter the student's identification number to proceed with the drop.

<div>
<img src="https://user-images.githubusercontent.com/104173074/185296777-2e16a4d5-43fc-43a6-afb2-24e56b38becc.png" height="35%" width="35%" >
<img src="https://user-images.githubusercontent.com/104173074/185296789-02c19760-e62a-4e30-8646-51cebdd4862d.png" height="40%" width="40%" >
</div><br/><br/><br/>

## 7 - STUDENT PORTAL

The student portal contains two pages: an Academic Record page, and another one for a Payment Management System. In the Academic Record area, students will be able to see their progress in current courses and grades from past courses. NOTE: The functionalities of seeing your class schedule for the week and generating a preliminary academic evaluation for graduation purposes are still under development. In the Payment Management System area, students will be able to pay their tuition, as well as apply for financial aid.<br/><br/>

### - Viewing academic record progress

To check current course progress, students will access their Academic Record page through the student portal and click the “Enrolled Course Progress” button. By doing so, the courses in which the student is enrolled will appear in the “Course” list. If one of the courses is chosen, the grades that the student has so far in that course will appear in the “Grade Detail” list. To check the grade for past courses, the procedure is the same, except that the “Completed Course Grades” button must be clicked instead of the “Enrolled Course Progress” button.

<img src="https://user-images.githubusercontent.com/104173074/185297575-21fdc761-3583-4567-97f5-413aaed99185.png" height="60%" width="60%" ><br/><br/>

### - Applying for financial aid

If the student wishes to apply for financial aid, they must go to the Payment Management System in the student portal and click on the “Apply for Student Aid” button. Financial aid determination is a process that involves many steps, but for purposes of this demonstration, the only requisite will be a household income of less than $30,000/year.  According to the annual household income that the student has entered in the admissions office, the system will automatically decide whether the student qualifies for financial aid or not.  If no household income was entered when the student's information was entered in the system in the admission's office portal, the system will let the student know they must submit that information to the office.  This can be done by going back to the admission's office portal, searching for the student by their identification number and updating their record.  Currently, the system automatically approves financial aid for students with an annual household income of less than $30,000 and covers 70% of their enrolled credits cost.<br/><br/>

### - Verifying account and financial aid balances

To verify the balance due and the balance of financial aid that has been provided to the student, click on the "Check Balance Due / Aid" button and the information will appear in the corresponding boxes.

<img src="https://user-images.githubusercontent.com/104173074/185298328-7ea90d94-2d16-48ea-b61e-3b5a148e2f32.png" height="60%" width="60%" ><br/><br/>

### - Making payments

To make tuition payments, the student can click on the “Make Payment” button. If the student has been awarded financial aid, it is automatically applied to towards their due balance and the new balance will be shown.

<div>
<img src="https://user-images.githubusercontent.com/104173074/185299055-b8a10907-7b11-4b3f-b5d2-3682c0c1cbcc.png" height="40%" width="40%" >
<img src="https://user-images.githubusercontent.com/104173074/185299065-45fde890-c097-4fe7-8570-3435d179aa3a.png" height="35%" width="35%" >
</div><br/>

The student then enters the amount they wish to pay towards their balance due and clicks the “OK” button.

<img src="https://user-images.githubusercontent.com/104173074/185299483-3ea9d557-a3d2-4711-b18a-dae45fca2dbc.png" height="40%" width="40%" >
