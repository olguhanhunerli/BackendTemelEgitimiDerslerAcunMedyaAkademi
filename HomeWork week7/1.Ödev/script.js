function updateClock() {
    const now = new Date();
    const hours = String(now.getHours()).padStart(2, '0');
    const minutes = String(now.getMinutes()).padStart(2, '0');
    const seconds = String(now.getSeconds()).padStart(2, '0');
    document.getElementById('clock').textContent = `${hours}:${minutes}:${seconds}`;
}
setInterval(updateClock, 1000);
updateClock(); 

// 2. Mesaj Gösterimi
document.getElementById('showMessage').addEventListener('click', function() {
    const message = document.getElementById('message');
    message.style.display = 'block';
    setTimeout(() => {
        message.style.display = 'none';
    }, 3000); 
});

const birthday = new Date('2024-12-20T00:00:00');
const countdownElement = document.getElementById('countdown');

function updateCountdown() {
    const now = new Date();
    const timeDifference = birthday - now;
    const days = Math.floor(timeDifference / (1000 * 60 * 60 * 24));
    const hours = Math.floor((timeDifference / (1000 * 60 * 60)) % 24);
    const minutes = Math.floor((timeDifference / (1000 * 60)) % 60);
    const seconds = Math.floor((timeDifference / 1000) % 60);
    
    countdownElement.textContent = `${days} gün ${hours} saat ${minutes} dakika ${seconds} saniye kaldı`;
}
setInterval(updateCountdown, 1000);

setTimeout(function() {
    window.location.href = "https://www.acunmedyaakademi.com";
}, 5000); 
