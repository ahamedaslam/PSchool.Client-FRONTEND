//smooth scroll to top

window.scrollToTop = () => {
    window.scrollTo({ top: 0, behavior: 'smooth' });
};

//focus first input on the page
window.focusFirstInput = () => {
    const input = document.querySelector('input,textarea');
    if (input) input.focus();
};