# snowflake-dotnetcore-connector-sample
A Snowflake dotnet core connector sample that uses dotnet core 3.1 and the [official Snowflake Dotnet connector](https://github.com/snowflakedb/snowflake-connector-net)

## Prerequisites
- Install dotnet core 3.1 SDK from [here](https://dotnet.microsoft.com/download/dotnet-core/3.1)
- I used VSCode to build the app, but you are free to use whatever IDE you want

## To run
* Replace these placeholders in the connection string
    * `{ACCOUNT_NAME}` with your account name, for example it can be something like mzaatar123 
    * `{HOSTNAME}` with your hostname. It is the first part of the url when you are trying to access the console, for example it can be something like mzaatar123. The full host parameter will be something like `mzaatar123.snowflakecomputing.com`
    * `{USERNAME}` is the username you use to connect to the Snowflake console
    * `{PASSWORD}` is the password you use to connect to the Snowflake console
    * `{DBNAME}` is the db name and it is an optional one. For example 'mycompany_staging'
    * `{ROLE}` is your role for your username and and it is an optional one. For example 'data_scientist'
* Run this command in the root directory `dotnet run`
* The console log should show your Snowflake region. For example, it might be `us_west_1`
