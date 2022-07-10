# Ecom-Test-API
Basic E-Commerce API that handles Customers, Products, and Transactions.

----------
Create migration using:

dotnet ef add migration <migrationName> --context EcomContext


----------
Transalate changes to database using:

dotnet ef update database --context EcomContext

----------
An error will pop up in the dotnet console.
To fix the error, add the following lines to the postgres query editor:

ALTER TABLE "Transactions" ALTER COLUMN "TransactionTime" TYPE TIMESTAMP without time zone USING create_time_holder;
ALTER TABLE "Transactions" ALTER COLUMN "TransactionDate" TYPE TIMESTAMP without time zone USING create_time_holder;

----------
After making changes explicitly to the database, run the program to begin the seeding:

dotnet run
