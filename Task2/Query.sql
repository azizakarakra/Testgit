SELECT s.id, s.name
FROM Student s
WHERE NOT EXISTS (
    SELECT 1
    FROM StudentSubject ss
    WHERE ss.student_id = s.id AND ss.grade < 60
)
ORDER BY (SELECT AVG(ss.grade) FROM StudentSubject ss WHERE ss.student_id = s.id) DESC
LIMIT 3;