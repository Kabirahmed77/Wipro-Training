const readline=require("readline");
const r1=readline.createInterface({
    input: process.stdin,
    output: process.stdout,
});
r1.question("Enter the student name: ",function(stud_name){ 
    r1.question("Enter the student age: ",function(stud_age){ //need to convert
        r1.question("Enter the mark: ",function(stud_marks){ //need to convert
            r1.question("Enter the course name: ",function(stud_course){
                r1.question("Enter the user role: ",function(user_role){ //need to convert
                    stud_age=Number(stud_age);
                    stud_marks=Number(stud_marks);
                    user_role=user_role.toLowerCase();
                    
                    //Display the info
                    console.log("Name is: ",stud_name);
                    console.log("Age is: ",stud_age);
                    console.log("Marks is: ",stud_marks);
                    console.log("Course is: ",stud_course);
                    console.log("User role is: ",user_role);
                    
                    //checking the type
                    console.log("type of the name is: ",typeof(stud_name));
                    console.log("type of the age is: ",typeof(stud_age));
                    console.log("type of the marks is: ",typeof(stud_marks));
                    console.log("type of the course name is: ",typeof(stud_course));
                    console.log("type of the user role is: ",typeof(user_role));
                    
                    //Assigining the grade 
                    if (stud_marks===100)
                    {
                        console.log("Centum!!!");
                    }
                    else if (stud_marks >= 90)
                    {
                        console.log("Grade A");
                    }
                    else if (stud_marks >=75)
                    {
                        console.log("Grade B");
                    }
                    else if(stud_marks >= 50)
                    {
                        console.log("Grade C");
                    }
                    else
                    {
                        console.log("Fail");
                    }
                    
                    //chr=ecking eligiblity for the admission
                    if(stud_age >= 17)
                    {
                        console.log("Eligible for admission");
                    }
                    else
                    {
                        console.log("Not eligible forr admission");
                    }
                    //Access system
                    if(user_role=="admin")
                    {
                        console.log("Access granted for the admin");
                    }
                    else if(user_role=="staff")
                    {
                        console.log("Access granted for the staff");
                    }
                    else if(user_role=="student")
                    {
                        console.log("Access granted for the student");
                    }
                    else
                    {
                        console.log("*********ACCESS DENIED*********");
                    }
                    
                });
            });
        });
    });
});