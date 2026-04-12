Cybersecurity Awareness Bot

 Project Overview

The Cybersecurity Awareness Bot is a C# console application designed to educate users about basic cybersecurity concepts.

The bot interacts with users in a visually engaging way using:

* Voice greeting (WAV audio)
* ASCII art banner
* Typing effects
* Colorful console interface

It provides simple explanations about cybersecurity topics such as phishing, passwords, and malware.



 Features

 Voice Greeting

* Plays a `.wav` file (`Greeting.wav`) when the program starts
* Uses `SoundPlayer` from `System.Media`

 ASCII Art UI

* Displays a styled cybersecurity banner
* Uses console colors for a professional look

 User Interaction

* Prompts user for their name
* Personalizes responses

 Chatbot System

The bot responds to:

* "purpose" → explains its role
* "phishing" → explains phishing attacks
* "password" → gives password tips
* "malware" → explains malware
* "cyber" → general cybersecurity info

 Input Validation

* Handles empty input
* Prompts user again if input is invalid

Effects & UI Enhancements

* Typing animation effect
* “Thinking…” animation
* Status bar display
* Startup boot sequence
* Exit sequence


Project Structure

```
CybersecurityAwarenessBot/
│
├── Program.cs        // Entry point
├── Chatbot.cs        // Main chatbot logic
├── User.cs           // User data handling
├── AudioPlayer.cs    // Audio playback
├── Greeting.wav      // Voice greeting file
```

---

 How to Run the Program

1. Open the project in Visual Studio

2. Make sure `Greeting.wav` is in the output folder:

  
   bin/Debug/netX.X/
  

3. Install required package:

    Go to:
     Tools → NuGet Package Manager → Manage NuGet Packages
     Install:
     `System.Windows.Extensions`

4. Run the program


Example Interaction


Initializing system...
Loading security modules...
Launching AI interface...

Enter your name to continue: John

Welcome, John.
AI Cybersecurity Assistant is now active.

>> Ask a cybersecurity question:
> phishing

Analyzing input...

ALERT: Phishing is when attackers trick you into giving sensitive information.


GitHub & CI

* Repository is hosted on GitHub
* Includes multiple commits showing development progress
* GitHub Actions CI is configured using `.NET workflow`




 Video Demonstration

The project presentation includes:

* Running application demo
* Code walkthrough
* Explanation of logic and features
* Voice narration (not AI-generated)



Technologies Used

* C# (.NET Console Application)
* System.Media (Audio playback)
* Console UI styling (colors, animations)



Conclusion

This project demonstrates:

* Object-oriented programming (classes & structure)
* User interaction in console applications
* Basic cybersecurity awareness concepts
* Clean UI/UX in a console environment



 Author

Student Name: Zekhaya Manxusa
Course: PROG6221
