// js/interaction.js

document.addEventListener('DOMContentLoaded', () => {
    const smoothLinks = document.querySelectorAll('a[href^="#"]');

    smoothLinks.forEach(link => {
        link.addEventListener('click', event => {
            event.preventDefault();
            const targetId = link.getAttribute('href').slice(1);
            const targetElement = document.getElementById(targetId);
            if (!targetElement) return;

            window.scrollTo({
                top: targetElement.offsetTop - 70,
                behavior: 'smooth'
            });
        });
    });

    const contactForm = document.querySelector('.contact-form');
    if (contactForm) {
        contactForm.addEventListener('submit', event => {
            event.preventDefault();
            const nome = contactForm.querySelector('#nome');
            const email = contactForm.querySelector('#email');
            const mensagem = contactForm.querySelector('#mensagem');

            if (!nome.value.trim() || nome.value.trim().length < 3) {
                alert('Informe um nome válido com ao menos 3 caracteres.');
                nome.focus();
                return;
            }

            const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
            if (!emailRegex.test(email.value)) {
                alert('Informe um e-mail válido.');
                email.focus();
                return;
            }

            if (!mensagem.value.trim() || mensagem.value.trim().length < 10) {
                alert('Informe uma mensagem com pelo menos 10 caracteres.');
                mensagem.focus();
                return;
            }

            alert('Mensagem enviada com sucesso! Responderemos em breve.');
            contactForm.reset();
        });
    }
});