# 📧 Spam Sense: ML-Powered Message Classifier

<div align="center">

![.NET](https://img.shields.io/badge/.NET-7.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![ML.NET](https://img.shields.io/badge/ML.NET-Machine%20Learning-orange?style=for-the-badge&logo=microsoft)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-WinForms-0078D4?style=for-the-badge&logo=windows)
![Docker](https://img.shields.io/badge/Docker-Container-2496ED?style=for-the-badge&logo=docker&logoColor=white)

**AI-Powered Spam Detection Desktop Application** *Built with C# • .NET 7 • ML.NET • WinForms*

---

*Classifies messages as Spam or Ham with real-time probabilistic predictions.* *A comprehensive demonstration of Machine Learning integration within the .NET ecosystem.*

</div>

---

## 📋 Table of Contents
- [📌 About the Project](#-about-the-project)
- [✨ Features](#-features)
- [📸 Screenshots](#-screenshots)
- [🛠️ Tech Stack](#-tech-stack)
- [📊 Dataset](#-dataset)
- [🚀 Setup Instructions](#-setup-instructions)
- [📁 Project Structure](#-project-structure)
- [🐳 Dockerization](#-dockerization)
- [👨‍💻 Developer Details](#-developer-details)

---

## 📌 About the Project

**Spam Sense** is a specialized desktop utility designed to filter communication by identifying patterns in text data. Using a binary classification model, it distinguishes between:

- ✅ **Ham:** Legitimate, safe, and personal messages.
- ❌ **Spam:** Unsolicited, commercial, or potentially malicious messages.

### 🎯 Objective
This project serves as a practical implementation of the **AI Development Lifecycle**, covering everything from data preprocessing and model training to GUI integration and containerized deployment.

---

## ✨ Features

| Feature | Description |
|:---|:---|
| ⚡ **Real-Time Prediction** | High-speed text analysis for instant classification results. |
| 🧠 **ML.NET Model** | Utilizes the SDCA (Stochastic Dual Coordinate Ascent) algorithm. |
| 🔄 **In-App Training** | Ability to retrain the model directly through the user interface. |
| 💻 **Native GUI** | Clean and intuitive Windows Forms interface for ease of use. |
| 🐳 **Docker Ready** | Fully containerized build environment for consistent deployment. |
| ⚠️ **Input Validation** | Robust error handling to prevent crashes on empty or invalid data. |

---

## 📸 Screenshots

| 🖥️ WinForms Interface | 📊 Model Performance |
|:---:|:---:|
| ![Main UI](./SpamSense/screenshots/ui_screenshot.png) | ![Accuracy](./SpamSense/screenshots/model_accuracy.png) |
| *User-friendly classification dashboard* | *Training metrics and accuracy results* |

---

## 🛠️ Tech Stack

- **Backend:** C# (.NET 7.0)
- **AI Engine:** ML.NET (Binary Classification)
- **UI Framework:** Windows Forms (WinForms)
- **DevOps:** Docker (Linux-based SDK environments)
- **Version Control:** Git & GitHub

---

## 📊 Dataset

The model is trained using the **SMS Spam Collection Dataset**, a public set of labeled SMS messages. 
- **Format:** Tab-separated or CSV values.
- **Preprocessing:** Text featurization and word-tokenization are handled via the ML.NET pipeline.

---

## 🚀 Setup Instructions

### ✅ Prerequisites
- **Visual Studio 2022** (with .NET Desktop Development workload)
- **.NET 7 SDK**
- **Docker Desktop** (optional, for containerization testing)

### ▶️ Run the Project Locally
1. Clone the repository:
   ```bash
   git clone [https://github.com/MuhammedHarib/Spam-Classifier-Project.git](https://github.com/MuhammedHarib/Spam-Classifier-Project.git)
