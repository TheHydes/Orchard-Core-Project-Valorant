(function initTargetBlank() {
    function highlightActiveMenuItem() {
        const listItems = document.querySelectorAll('.valorantStuffMainMenu__mainMenu li');

        listItems.forEach((li) => {
            const link = li.querySelector('a');

            if (link && link.getAttribute('href') === window.location.pathname) {
                li.classList.add('currentPage');
            }
        });
    }

    document.addEventListener('DOMContentLoaded', highlightActiveMenuItem);
})();
