# Personal online portfolio

My personal portfolio website, built to showcase my background, experience, projects, and skills.

🔗 **Live site:** https://lavinia-dim-portfolio-c4dhdqaecuapc6fz.swedencentral-01.azurewebsites.net/
> **Note:** This site is hosted on Azure's free tier, which spins down after periods of inactivity. The first load after some idle time may take up a few seconds.

## Tech stack

- **Backend:** ASP.NET Core MVC (.NET 10)
- **Frontend:** Razor views, CSS, JavaScript
- **Data:** Content is stored in local JSON files and read via a service layer (no database by design, given the site's scale)
- **Hosting:** Azure App Service, with automatic deployment via GitHub Actions on every push to `main`
