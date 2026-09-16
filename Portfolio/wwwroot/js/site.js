document.addEventListener("DOMContentLoaded", () => {
    const sections = document.querySelectorAll("main section[id]");
    const navLinks = document.querySelectorAll(".main-nav a[data-section]");

    function updateActiveLink() {
        const midpoint = window.innerHeight / 2;
        let currentId = sections[0]?.id ?? null;

        sections.forEach(section => {
            const rect = section.getBoundingClientRect();
            if (rect.top <= midpoint) {
                currentId = section.id;
            }
        });

        navLinks.forEach(link => {
            link.classList.toggle("active", link.dataset.section === currentId);
        });
    }

    window.addEventListener("scroll", updateActiveLink);
    window.addEventListener("resize", updateActiveLink);
    updateActiveLink();
});