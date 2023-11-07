-- Create the Comment table
CREATE TABLE Comment (
                         Id INT IDENTITY(1,1) PRIMARY KEY, -- Auto-generative serial ID
                         Title NVARCHAR(255),
                         Description NVARCHAR(MAX),
                         Username NVARCHAR(50)
);