<!-- portfolio -->
<!-- slug: penilaian -->
<!-- title: Aplikasi Penilaian Sekolah -->
<!-- description: Desktop-based school grading application to help schools manage student grades efficiently -->
<!-- image: https://github.com/user-attachments/assets/placeholder-penilaian -->
<!-- tags: c#, .net, mysql, desktop-app, school-management -->

# School Grading Application (Aplikasi Penilaian Sekolah)

A desktop-based school grading and assessment management application built with C# .NET and MySQL, designed to help schools efficiently manage and process student grades.

## 📋 Overview

This application was developed as an educational project to assist schools in managing their student grading system. It provides a comprehensive solution for teachers and administrators to input, calculate, and track student academic performance throughout the semester.

## ✨ Features

- **Student Grade Management**
  - Input and update student grades
  - Automatic grade calculation
  - Semester-based grade tracking
  - Subject-wise performance monitoring

-  **Grade Processing**
  - Calculate final grades based on weighted criteria
  - Generate grade reports
  - Export grade summaries

- **User-friendly Interface**
  - Clean desktop GUI built with Windows Forms
  - Intuitive navigation
  - Data grid views for easy data management

- **Data Management**
  - MySQL database integration
  - Secure data storage
  - Data validation and error handling

## 🛠️ Technologies Used

- **Language**: C# (.NET Framework)
- **IDE**: Visual Studio
- **Database**: MySQL
- **UI Framework**: Windows Forms
- **Data Access**: ADO.NET / MySQL Connector

## 📁 Project Structure

```
Penilaian/
├── Penilaian/                  # Main application folder
│   ├── Forms/                  # UI Forms
│   ├── Models/                 # Data models
│   ├── Controllers/            # Business logic
│   └── Database/               # DB connection classes
├── Penilaian.sln               # Solution file
├── db_penilaian.sql           # Database schema
└── README.md
```

## 🚀 Getting Started

### Prerequisites

- Visual Studio 2019 or later
- MySQL Server 5.7 or later
- .NET Framework 4.7.2 or higher
- MySQL Connector/NET

### Installation Steps

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd Penilaian
   ```

2. **Setup Database**
   - Open MySQL Workbench or phpMyAdmin
   - Create a new database named `db_penilaian`
   - Import the SQL file:
   ```sql
   mysql -u root -p db_penilaian < db_penilaian.sql
   ```

3. **Configure Database Connection**
   - Open the project in Visual Studio
   - Update the connection string in `App.config` or connection class:
   ```xml
   <connectionStrings>
     <add name="DbConnection" 
          connectionString="Server=localhost;Database=db_penilaian;Uid=root;Pwd=yourpassword;" 
          providerName="MySql.Data.MySqlClient"/>
   </connectionStrings>
   ```

4. **Install MySQL Connector**
   - Right-click on project → Manage NuGet Packages
   - Search for "MySql.Data"
   - Install the package

5. **Build and Run**
   - Press F5 or click "Start" in Visual Studio
   - The application will compile and launch

## 💻 Usage

1. **Login**
   - Launch the application
   - Enter your credentials (admin/teacher)

2. **Manage Student Grades**
   - Select class and subject
   - Input student scores for assignments, quizzes, midterm, and final exam
   - System automatically calculates final grades

3. **Generate Reports**
   - Select reporting period
   - Choose class/student
   - Generate and export grade reports

4. **View Statistics**
   - Access dashboard for performance overview
   - View class averages and distributions

## 🎯 Use Cases

- **For Teachers**: Input and track student grades efficiently
- **For School Administrators**: Overview of school-wide academic performance
- **For Academic Staff**: Generate comprehensive grade reports

## 🔒 Database Schema

The `db_penilaian.sql` file contains:
- Student information tables
- Subject and class tables
- Grade records tables
- User authentication tables

## 🤝 Contributing

This project was created for educational purposes to assist schools in grade management. Contributions and improvements are welcome!

## 📄 License

This project is open source and available for educational purposes.

## 📞 Contact

For questions or support, please reach out via the contact information in my portfolio.
