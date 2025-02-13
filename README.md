# Remote Robotic Arm Control (C# & ESP32)

## Overview
This project proposes a **desktop application in C#** that enables remote control of a robotic arm using two **ESP32 microcontrollers**. The system is designed to provide a fast and simple interface for educational robotics and prototyping applications.

![Robotic Arm Control](https://github.com/FaresAmor/Bras-Robotique/blob/main/APP.png)

## System Architecture
- The **transmitter ESP32** communicates with the **receiver ESP32** via the **ESP-NOW protocol** to send robotic arm commands.
- The **receiver ESP32**, connected to the **PC via UART**, receives instructions from the desktop application and forwards them to the robotic arm.

## Features
✔️ **Wireless communication** between ESP32 devices using ESP-NOW  
✔️ **UART-based control** between ESP32 and the PC  
✔️ **User-friendly desktop interface** for command execution  
✔️ **Ideal for educational and prototyping purposes**  

## Files Included
📁 **C# Desktop Application Source Code**  
📁 **ESP32 Firmware**  
📁 **Circuit Diagrams & Schematics**  
📁 **User Guide & Documentation**  

## Installation & Usage
1. **Setup ESP32 devices** with the provided firmware.
2. **Connect the receiver ESP32** to the PC via UART.
3. **Run the C# desktop application** to send movement commands.
4. **Observe the robotic arm responding in real-time.**


## Contribution
Feel free to explore, modify, and contribute! If you find any issues or improvements, open a pull request or raise an issue. 🚀


