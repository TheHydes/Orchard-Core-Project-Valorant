(function initializeExpandableWidgetAnimation() {
    Array
        .from(document.getElementsByClassName('ExpandableWidget'))
        .forEach((widget) => widget
            .querySelector('.ExpandableWidget__title')
            ?.addEventListener('click', function toggle() {
                widget.classList.toggle('open');
            }));
})();
