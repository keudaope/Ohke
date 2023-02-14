let navLinks = document.querySelectorAll('.navbar a');
let currentUrl = window.location.href;

navLinks.forEach(link => {
  if (link.href === currentUrl) {
    link.classList.add('active');
  }
});