# Break it, fix it

Small Unity projects with planted bugs. Each folder is its own Unity project: open the folder you need with **Unity Hub → Add → Add project from disk**. Pick the project folder (for example `Screens`), not the repo folder itself: Unity Hub answers "Please add a valid project" if you pick `break-and-fix`.

| Folder | Topic | What's broken |
| --- | --- | --- |
| `Screens/` | Screens, touch and the Android build | Five bugs that only show up on real phones |

## Screens

A tiny game: tap the green button to earn a coin. Every coin makes the orange box spin faster.

1. Clone this repo.
2. Unity Hub → **Add** → **Add project from disk** → pick the `Screens` folder inside the repo (not `break-and-fix` itself). Open it with the same Unity version you use in class.
3. Open `Assets/Scenes/Main.unity`.
4. Look at the game in the **Device Simulator** (Window → General → Device Simulator). Try a phone with a camera hole and an old 16:9 phone. Then build it to a real Android phone.

For each bug, write down:

| What you saw | Which setting or line causes it | The fix |
| --- | --- | --- |
| | | |

Hints, if you're stuck:

- Look at the Canvas and its Canvas Scaler.
- Look at Edit → Project Settings → Player → Android tab.
- Install your build and your neighbour's build on the same phone. What happens?
- Did it install on every phone in your pair?

Fix all five, build again, and show the fixed game running on a phone.
