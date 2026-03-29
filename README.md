# 📧 Spam Sense: ML-Powered Message Classifier

[![.NET 7.0](https://img.shields.io/badge/.NET-7.0-blue.svg)](https://dotnet.microsoft.com/)
[![ML.NET](https://img.shields.io/badge/ML.NET-Machine%20Learning-orange.svg)](https://dotnet.microsoft.com/apps/machinelearning-ai/ml-dotnet)
[![Docker](https://img.shields.io/badge/Docker-Container-blue.svg)](https://www.docker.com/)

A professional-grade **C# .NET** desktop application that leverages **ML.NET** to identify spam with high accuracy. This project demonstrates the integration of machine learning within a **WinForms** GUI and showcases containerization patterns using **Docker**.

---

## 📌 Project Description
This project is a high-performance **Spam Message Classifier**. By using a trained binary classification model, the application can distinguish between legitimate messages (**Ham**) and unwanted commercial or malicious messages (**Spam**).

### 🚀 Key Features
* **Real-time Prediction:** Instant classification of text input.
* **On-the-Fly Training:** Retrain the model directly from the UI using the latest datasets.
* **Binary Classification:** Optimized using the SDCA (Stochastic Dual Coordinate Ascent) algorithm.
* **Dockerized Workflow:** Ready for CI/CD environments to demonstrate build consistency.

---

## 🧠 Technologies Used
* **C# (.NET 7.0)**: Core programming language.
* **ML.NET**: Open-source machine learning framework for .NET.
* **WinForms**: Desktop graphical user interface.
* **Docker**: For containerized build and execution testing.

---

## ⚙️ Setup & Installation

### 1. Run the WinForms Application (Windows)
1.  Open the solution file (`.sln`) in **Visual Studio 2022**.
2.  Restore NuGet packages via the **Package Manager Console**.
3.  Press `Ctrl + F5` to run the project.
4.  Click **"Train Model"** to generate the `.zip` model file.
5.  Enter a message and click **"Predict"** to see the result.

### 2. Docker Setup (Build Demo)
> **Note:** Because WinForms requires a Windows GUI subsystem, Docker is used here to demonstrate the **build process** and **headless execution** of the ML logic.

```bash
# Build the Docker Image
docker build -t spam-app .

# Run the Container
docker run spam-app
