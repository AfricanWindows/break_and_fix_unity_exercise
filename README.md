# Break it, fix it

One Unity project full of small broken games. Each scene is one exercise with planted bugs: find them before your players do.

## Open it

1. Clone this repo.
2. Unity Hub → **Add** → **Add project from disk** → pick the cloned `break-and-fix` folder. Open it with the same Unity version you use in class.
3. Open the exercise's scene from `Assets/Scenes`.

| Scene | Exercise |
| --- | --- |
| `01_ShipToPhone` | Six bugs that only show up on real phones |

## 01_ShipToPhone

A tiny game: tap the green button to earn a coin. Every coin makes the orange box spin faster.

1. Open `Assets/Scenes/01_ShipToPhone.unity`.
2. Look at the game in the **Device Simulator** (Window → General → Device Simulator). Try a phone with a camera hole and an old 16:9 phone.
3. Build it to a real Android phone (File → Build Profiles → Android → Build And Run).

For each bug, write down:

| What you saw | Which setting or line causes it | The fix |
| --- | --- | --- |
| | | |

Hints, if you're stuck:

- Look at the Canvas and its Canvas Scaler.
- Look at Edit → Project Settings → Player → Android tab.
- Install your build and your neighbour's build on the same phone. What happens?
- Did it install on every phone in your pair?
- Can you hit the button with your thumb, on every phone?

Fix all six, build again, and show the fixed game running on a phone.
