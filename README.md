🍎 Fruit Catcher
A colourful, arcade-style falling-objects game built with C# Windows Forms (.NET Framework 4.7.2). Move your basket to catch falling fruits, dodge the bombs, and climb to Level 10!

🎮 Gameplay Preview
Fruit Catcher Gameplay

✨ Features
10 Progressive Levels — speed increases every 10 fruits caught
7 Fruit Types — Banana 🍌, Apple 🍎, Strawberry 🍓, Kiwi 🥝, Orange 🍊, Grapes 🍇, Pineapple 🍍
Bomb Hazard — catch a bomb and it's game over instantly!
Animated Sky Background — 15 drifting clouds + 3 birds flying across at different speeds
Full Audio — looping background music, fruit-catch chime, and explosion sound
Pause / Resume — press Space to pause mid-game
Clean Spawn Logic — fruits and bombs check for spacing before spawning to prevent overlaps
Restart without relaunch — full state reset from the in-game menu
🕹️ Controls
Key	Action
←	Move Basket Left
→	Move Basket Right
↑	Move Basket Up
↓	Move Basket Down
Space	Pause / Unpause
🏗️ Tech Stack
Layer	Detail
Language	C#
Framework	.NET Framework 4.7.2
UI	Windows Forms (WinForms)
Audio	WMPLib (Windows Media Player COM Interop)
IDE	Visual Studio 2022
📁 Project Structure
FRUIT CATCHER/
├── FRUIT CATCHER.slnx           # Solution file
└── FRUIT CATCHER/
    ├── Form1.cs                 # Core game logic
    ├── Form1.Designer.cs        # UI layout
    ├── Program.cs               # Entry point
    ├── Resources/               # Background images, basket, birds
    ├── bin/Debug/
    │   ├── characters/          # Fruit, bomb, cloud sprites
    │   └── sound/               # Audio files (game, catch, boom)
    └── Properties/
⚙️ Getting Started
Prerequisites
Windows OS
Visual Studio 2022 (or later)
.NET Framework 4.7.2
Windows Media Player installed (for audio)
Run the Game
Clone or download the repository
Open FRUIT CATCHER.slnx in Visual Studio
Update the hardcoded audio paths in Form1.cs to match your local directory:
gameMedia.URL = @"YOUR_PATH\sound\game.mp3";
catchMedia.URL = @"YOUR_PATH\sound\catch.mp3";
explosionMedia.URL = @"YOUR_PATH\sound\boom.mp3";
Build and run (F5)
Note: Sprite assets use Application.StartupPath (relative), but audio paths are still hardcoded to D:\C#\FRUIT CATCHER\.... Audio path fix is a planned improvement.

🎯 Game Logic Highlights
Smart Spawn System — IsPositionClear() checks existing visible items near the top before spawning a new fruit or bomb, avoiding unfair overlaps
Separate Spawn Timers — FruitSpawnTimer and BombSpawnTimer run independently, keeping spawning unpredictable
Level Scaling — every 10 fruits caught: fruitspeed++, bombspeed++, level++
Animated Background — 3 birds at speeds 1, 2, 3 px/tick loop across; 15 clouds drift downward and wrap
Double-Buffered Rendering — smooth animation via this.DoubleBuffered = true
🔮 Planned Improvements
 Fix hardcoded audio paths to use Application.StartupPath
 Add lives system (3 misses = game over)
 High score leaderboard
 Animated fruit sprites
 Sound toggle button in UI
👨‍💻 Author
Built as a C# Windows Forms learning project — practicing timer-driven animation, collision detection, dynamic sprite spawning, and COM audio interop.

📜 License
This project is open source and available under the MIT License.
