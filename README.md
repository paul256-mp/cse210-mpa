
Class Diagram
Comment Class
Copy
+---------------------+
|       Comment       |
+---------------------+
| - Name: string      |
| - Text: string      |
+---------------------+
| + Comment(name, text)|
+---------------------+

+---------------------+
|        Video        |
+---------------------+
| - Title: string     |
| - Author: string    |
| - Length: int       |
| - _comments: List<Comment> |
+---------------------+
| + Video(title, author, length) |
| + AddComment(comment)          |
| + GetNumberOfComments(): int  |
| + Comments (read-only list)    |
+---------------------+
Video "1" *-- "*" Comment : contains