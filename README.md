# Budget Generator

This is an application developed in VB with .NET 4.8 in Visual Studio, designed to facilitate the creation and management of budgets. The main goal of the project is to allow companies to create detailed budgets and generate automated reports.

## Features

- **Budget Creation**: Allows users to create budgets for their companies, including details of products and values.
  
- **Data Storage**: Budget data is saved in a database, including information such as date, company name, and item values.

- **Product Management**: Each company can save specific products for their budgets. For example, if the company OTOMAR creates a budget with 23 products, all 23 products are stored in the database with their respective details.

- **Report Generation**: After entering all products into the budget and finalizing it, the system generates an Excel file containing the budget details.

- **Automatic Printing**: The generated Excel file is automatically sent to the selected printer, facilitating the physical delivery of the budget.

## How to Use

1. **Initial Setup**: Ensure that the database is correctly configured and accessible by the application.

2. **Budget Creation**: Open the application, enter the company details, and add products to the budget.

3. **Finalization and Printing**: After entering all products, finalize the budget. The system will automatically create an Excel file and print it to the selected printer.

## Technologies Used

- **Programming Language**: VB.NET
- **Framework**: .NET 4.8
- **Database**: SQL Server (or other configured database)
- **Report Generation**: Excel

## Requirements

- Visual Studio 2019 or later
- .NET Framework 4.8
- Database configuration

## Contribution

Feel free to contribute improvements and fixes. To report issues or suggest new features, please open an [issue](link-to-issues) or submit a pull request.

## License

This project is licensed under the [MIT License](link-to-license).
