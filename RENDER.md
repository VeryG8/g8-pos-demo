# Deploy G8 POS Demo to Render

## Recommended repo structure
Best practice: place the `POS/` folder in its own GitHub repository before connecting Render.

If you keep the current structure, the relevant app path is:
- `POS/src/G8.PosDemo.Web`

## Option A: Blueprint deploy (`render.yaml`)
This project includes:
- `POS/render.yaml`
- `POS/src/G8.PosDemo.Web/Dockerfile`

Suggested flow:
1. Push the POS project to GitHub.
2. In Render, choose **New +** -> **Blueprint**.
3. Connect the GitHub repo.
4. Render will read `render.yaml` and create the web service.

## Option B: Manual Web Service setup
If you prefer manual setup in Render:

### Service type
- **Web Service**

### Runtime
- **Docker**

### Root directory
- `POS/src/G8.PosDemo.Web`

### Dockerfile path
- `./Dockerfile`

### Service name
- `g8-pos-demo`

### Plan
- Free (fine for demo use)

## What the Dockerfile does
- Builds the .NET 8 Blazor app
- Publishes it in Release mode
- Runs it on port `10000`
- Binds to `0.0.0.0` so Render can route traffic

## After deployment
Render will give you a public URL such as:
- `https://g8-pos-demo.onrender.com`

You can then open that URL from a tablet or phone for remote demo testing.

## Important current limitation
This is still a **demo deployment**, not a production POS system.
It currently has:
- no auth
- no real database
- no payment integration
- no hardware bridge

Use it for:
- tablet UI testing
- workflow review
- remote demo access

Do not use it as a real cashier system yet.
