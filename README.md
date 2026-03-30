# 📧 Spam Sense: ML-Powered Message Classifier

<div align="center">

![.NET](https://img.shields.io/badge/.NET-7.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ML.NET](https://img.shields.io/badge/ML.NET-Machine%20Learning-orange?style=for-the-badge&logo=microsoft)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-WinForms-0078D4?style=for-the-badge&logo=windows)
![Docker](https://img.shields.io/badge/Docker-Container-2496ED?style=for-the-badge&logo=docker&logoColor=white)

**AI-Powered Spam Detection Desktop Application** Built with C# · .NET 7 · ML.NET · WinForms

---

*Classifies messages as Spam or Ham with real-time predictions* *Demonstrates Machine Learning integration in .NET applications*

</div>

---

## 📋 Table of Contents

- [📌 About the Project](#-about-the-project)
- [✨ Features](#-features)
- [📸 Screenshots](#-screenshots)
- [🛠️ Tech Stack](#-tech-stack)
- [📊 Dataset](#-dataset)
- [🚀 Setup Instructions](#-setup-instructions)
- [📖 How to Use](#-how-to-use)
- [📁 Project Structure](#-project-structure)
- [🐳 Docker](#-docker)
- [👨&zwj;💻 Developer](#-developer)

---

## 📌 About the Project

**Spam Sense** is an AI-based desktop application that classifies text messages into:

- ✅ **Ham (Legitimate Message)**
- ❌ **Spam (Unwanted / Malicious Message)**

The application uses **ML.NET binary classification** to detect spam in real-time.

### 🎯 Problem Statement
Spam messages are a major issue in communication systems. Manually filtering them is inefficient and error-prone.

### 🎯 Objective
- Build a machine learning model using ML.NET  
- Integrate AI into a WinForms application  
- Provide real-time spam detection  
- Demonstrate Docker-based build process  

---

## ✨ Features

| Feature | Description |
|--------|------------|
| ⚡ Real-Time Prediction | Instantly classify messages |
| 🧠 ML.NET Model | Binary classification using SDCA |
| 🔄 Model Training | Train model from UI |
| 💻 Desktop UI | Built with Windows Forms |
| 🐳 Docker Support | Containerized build process |
| ⚠️ Error Handling | Handles invalid input safely |

---

## 📸 Screenshots
*(Add your screenshots here)*

---

## 🛠️ Tech Stack

| Technology | Purpose |
|-----------|--------|
| **C#** | Programming Language |
| **.NET 7.0** | Framework |
| **ML.NET** | Machine Learning |
| **WinForms** | UI |
| **Docker** | Containerization |

---

## 📊 Dataset

| Property | Value |
|--------|------|
| Type | SMS Spam Dataset |
| Format | CSV |
| Labels | Spam / Ham |
| Usage | Training ML Model |

---

## 🚀 Setup Instructions

### ✅ Prerequisites

- Visual Studio 2022  
- .NET 7 SDK  
- Docker (optional)

---

### ▶️ Run Application

1. Open `.sln` file in Visual Studio  
2. Restore packages  
3. Run the project  


Ctrl + F5

📁 Project StructurePlaintextSpamSense/
│
├── 📁 Data/
│   └── spam_dataset.csv
│
├── 📁 Models/
│   ├── InputData.cs
│   └── Prediction.cs
│
├── 📁 Services/
│   └── MLService.cs
│
├── 📁 Forms/
│   └── MainForm.cs
│
├── 📁 screenshots/
│   └── (Add images here)
│
├── Program.cs
├── SpamSense.csproj
├── Dockerfile
├── README.md
└── .gitignore
🐳 DockerDockerfile# Use official .NET SDK image as base
FROM [mcr.microsoft.com/dotnet/sdk:7.0](https://mcr.microsoft.com/dotnet/sdk:7.0)

# Set working directory inside container
WORKDIR /app

# Copy all project files into container
COPY . .

# Build the application
RUN dotnet build

# Run the application
CMD ["dotnet", "run"]
👨‍💻 DeveloperNameMuhammad HaribRoll No232201069InstituteKhan Institute of Computer Science and ITDepartmentComputer ScienceSubmitted ToSir Uzair Hassan
```bash
