# Unity 6 — 2D Game Development Mastery

A public, project-based learning repository focused on professional 2D game
development with Unity 6.

The goal is to progress from Unity fundamentals to the knowledge required to
design, build, profile, optimize, test, and prepare a high-quality 2D game for
commercial release.

The course focuses on illustrated / non-pixel-art 2D games and includes topics
such as gameplay systems, physics, animation, rendering, architecture,
performance, memory management, tooling, testing, production workflows, and
shipping.

## Course Baseline

- Unity 6.3 LTS
- Unity Editor `6000.3.21f1`
- Universal Render Pipeline (URP)
- Universal 2D Renderer
- Windows as the primary development environment
- macOS development support when available
- Visual Studio Code as the reference code editor

## Repository Structure

The repository contains multiple independent Unity projects.

Each course module has its own Unity project. Lessons that belong to the same
module build progressively on that project's contents.

Repository paths are intentionally kept short to reduce filesystem path length,
especially because Unity packages and generated caches can create deeply nested
directories.

```text
unity-6-2d-mastery/
│
├── 00-unity-fundamentals/
│   └── U6_00_UnityFundamentals/
│
├── 01-programming-fundamentals/
│   └── U6_01_CSharpFoundations/
│
└── ...
```

A Unity project contains its source assets, dependencies, and project
configuration under directories such as:

```text
Assets/
Packages/
ProjectSettings/
```

Generated directories such as `Library/`, `Temp/`, `Logs/`, and `UserSettings/`
are intentionally not stored in this repository.

Unity regenerates the required local data when a project is opened.

## Opening a Course Project

1. Install the Unity Editor version specified by the project or course section.
2. Clone or download this repository.
3. Open Unity Hub.
4. Select **Add project from disk**.
5. Select the Unity project directory for the section you want to study.
6. Allow Unity to import the project the first time it opens.

The first import can take longer because generated project data is not stored
in Git.

## Course Language

- Course documentation: Spanish
- Code and technical identifiers: English
- Public repository documentation may progressively be provided in both
  Spanish and English.

## Course Status

The course is under active development.

Current progress:

- [x] Unity environment and project fundamentals
- [ ] C# foundations for Unity
- [ ] Unity engine fundamentals
- [ ] 2D rendering pipeline
- [ ] Physics and character movement
- [ ] Animation
- [ ] Gameplay systems
- [ ] Architecture
- [ ] World architecture and streaming
- [ ] UI / UX
- [ ] Audio
- [ ] Performance engineering
- [ ] Testing and tooling
- [ ] Production and shipping