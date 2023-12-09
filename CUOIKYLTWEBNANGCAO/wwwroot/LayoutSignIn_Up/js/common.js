function togglePasswordVisibility() {
    var passwordField = document.getElementById('Password'); // Đặt ID của trường mật khẩu
    var eyeIcon = document.querySelector('.show-password');

    if (passwordField.type === 'password') {
        passwordField.type = 'text';
        eyeIcon.classList.remove('fa-eye');
        eyeIcon.classList.add('fa-eye-slash');
    } else {
        passwordField.type = 'password';
        eyeIcon.classList.remove('fa-eye-slash');
        eyeIcon.classList.add('fa-eye');
    }
}