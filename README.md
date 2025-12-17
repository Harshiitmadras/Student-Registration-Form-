# 🎓 Student Registration Form

A responsive **Student Registration Form** built using **HTML, Tailwind CSS, and Vanilla JavaScript**.  
This project demonstrates **client-side validation**, **DOM manipulation**, and a **dark mode toggle with persistence**.

Ideal for **beginner to intermediate frontend developers**, academic mini-projects, and portfolio use.

---

## 🚀 Features

- ✅ Responsive UI using **Tailwind CSS**
- 🌙 **Dark Mode toggle** with `localStorage` persistence
- 🧠 **Client-side form validation**
- ⚡ Prevents page reload on submission
- 📄 Displays submitted data dynamically below the form
- ♿ Semantic HTML and accessible labels
- 🧩 Clean and readable JavaScript code

---

## 🛠️ Tech Stack

| Technology | Purpose |
|----------|---------|
| HTML5 | Structure |
| Tailwind CSS | Styling & responsiveness |
| JavaScript (ES6) | Validation & DOM manipulation |
| localStorage | Theme persistence |

---

## 📂 Project Structure


---

## 🧪 Validation Rules

- **Name** → Must not be empty  
- **Email** → Must be a valid email address  
- **Gender** → One option must be selected  
- **Course** → Must select a course  
- **Terms & Conditions** → Must be accepted  

Error messages are shown inline below each field.

---

## 🖥️ Application Behavior

- Form submission handled using JavaScript
- No page reload occurs
- On successful submission:
  - Success message is displayed
  - Entered user details appear below the form
- On validation failure:
  - Submission is blocked
  - Inline error messages are displayed

---

## 🌙 Dark Mode

- Toggle button available in the header
- User preference saved using `localStorage`
- Previously selected theme loads automatically on refresh

---

## 📸 Sample Output

- Registration Successful!
- Name: Harsh
- Email: harsh@example.com
- Gender: Male
- Course: JavaScript



# Console-Based Patient Management System

## Features
- Object-Oriented Design
- Patient Type Abstraction
- Factory Pattern
- Delegate-based Billing Strategy
- Event-driven Notifications
- Console-based interaction

## Flow
1. Admit Patient
2. Select Patient Type
3. Calculate Treatment Bill
4. Apply Billing Strategy (Delegate)
5. Generate Bill
6. Trigger Events and Notify Departments

## How to Run
```bash
dotnet build
dotnet run
```

## Technologies
- C#
- .NET 6
- Delegates & Events
