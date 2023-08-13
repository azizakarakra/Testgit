-- Create the 'student' table
CREATE TABLE student (
    stId INT PRIMARY KEY,
    name VARCHAR(50)
);

-- Create the 'subject' table
CREATE TABLE subject (
    subId INT PRIMARY KEY,
    name VARCHAR(50)
);

-- Create the junction table 'student_subject' for many-to-many relationship
CREATE TABLE student_subject (
    stId INT,
    subId INT,
    grade VARCHAR(10), -- Add the grade column
    PRIMARY KEY (stId, subId),
    FOREIGN KEY (stId) REFERENCES student(stId),
    FOREIGN KEY (subId) REFERENCES subject(subId)
);

-- Insert data into the 'student' table
INSERT INTO student (stId, name) VALUES
    (1, 'Aziza'),
    (2, 'Malak'),
    (3, 'Aya');

-- Insert data into the 'subject' table
INSERT INTO subject (subId, name) VALUES
    (101, 'Math'),
    (102, 'Science'),
    (103, 'History');

-- Insert data into the 'student_subject' table with grades
INSERT INTO student_subject (stId, subId, grade) VALUES
    (1, 101, '99'),
    (1, 102, '80'),
    (2, 102, '70'),
    (2, 103, '79'),
    (3, 101, '94'),
    (3, 103, '90');
