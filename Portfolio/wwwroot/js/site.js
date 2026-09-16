document.addEventListener("DOMContentLoaded", () => {
    const sections = document.querySelectorAll("main section[id]");
    const navLinks = document.querySelectorAll(".main-nav a[data-section]");

    function updateActiveLink() {
        let currentId = sections[0]?.id ?? null;

        sections.forEach(section => {
            const rect = section.getBoundingClientRect();
            if (rect.top <= 180) {
                currentId = section.id;
            }
        });

        if (window.innerHeight + window.scrollY >= document.documentElement.scrollHeight - 10) {
            currentId = sections[sections.length - 1]?.id ?? currentId;
        }

        navLinks.forEach(link => {
            link.classList.toggle("active", link.dataset.section === currentId);
        });
    }

    window.addEventListener("scroll", updateActiveLink);
    window.addEventListener("resize", updateActiveLink);
    updateActiveLink();
});