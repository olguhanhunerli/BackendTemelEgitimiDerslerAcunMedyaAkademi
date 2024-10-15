// Login modalını açma ve kapama işlemleri
const loginBtn = document.getElementById('loginBtn');
const loginModal = document.getElementById('loginModal');
const closeModal = document.querySelector('.close');
const submitLogin = document.getElementById('submitLogin');
const result = document.getElementById('result');

// Sabit kullanıcı adı ve parola
const validUsername = 'olguhan';
const validPassword = 'FENERBAHCE';

// Login butonuna tıklanınca modalı aç
loginBtn.addEventListener('click', () => {
    loginModal.style.display = 'flex';
});

// X işaretine tıklanınca modalı kapat
closeModal.addEventListener('click', () => {
    loginModal.style.display = 'none';
});

// Giriş yap butonuna tıklanınca kontrol et
submitLogin.addEventListener('click', () => {
    const username = document.getElementById('username').value;
    const password = document.getElementById('password').value;
    
    if (username === validUsername && password === validPassword) {
        result.textContent = 'HOŞ GELDİNİZ';
        result.style.color = 'green';
    } else {
        result.textContent = 'Başarısız İşlem';
        result.style.color = 'red';
    }

    // Modalı kapat
    loginModal.style.display = 'none';
});
