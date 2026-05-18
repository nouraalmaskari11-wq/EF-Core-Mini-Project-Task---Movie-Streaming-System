# 🎬 Movie Streaming System

Movie Streaming Management System using Entity Framework Core and Windows Forms.

## Features

### ✅ Core Features
- CRUD Operations for Movies, Users, Reviews
- One-to-Many Relationships (Category → Movies, User → Reviews, Movie → Reviews)
- Many-to-Many Relationships (User ↔ Movie via Watchlist)
- Soft Delete for Movies and Reviews
- Timestamps (CreatedAt, UpdatedAt)

### ✅ Bonus Features
- Top Rated Movies
- Filter Movies by Category
- Prevent duplicate movies in Watchlist
- Global Query Filters for Soft Delete

## 🛠️ Technologies Used

- .NET 8
- Entity Framework Core
- SQL Server LocalDB
- Windows Forms

## 📋 Database Schema

- User (Id, Name, Email, CreatedAt)
- Movie (Id, Title, Description, ReleaseYear, CategoryId, CreatedAt, IsDeleted)
- Category (Id, Name)
- Review (Id, Comment, Rating, UserId, MovieId, CreatedAt, IsDeleted)
- Watchlist (UserId, MovieId, AddedDate)

## 🚀 How to Run

1. Clone the repository
2. Open with Visual Studio 2022
3. Update database:
4. Run the project (F5)
