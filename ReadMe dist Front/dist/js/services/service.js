btn_register = document.querySelector("[data-register-btn]");

btn_register.addEventListener("click", (e) => {
  e.preventDefault();
  const name = document.querySelector("[data-name-register]"),
    subname = document.querySelector("[data-subname-register]"),
    email = document.querySelector("[data-email-register]"),
    password = document.querySelector("[data-password-register]"),
    confirmPassword = document.querySelector("[data-check-password-register]");
  if (password.value == confirmPassword.value) {
    const user = {
      Name: name.value,
      Subname: subname.value,
      Email: email.value,
      Password: password.value,
      ConfirmPassword: confirmPassword.value,
    };
    const user1 = JSON.stringify(user);
    postData("https://habitme.azurewebsites.net/api/Auth/Register", user1).then(
      (data) => {
        alert(data);
      }
    );
  } else {
    alert("Паролі не збігаються");
  }
});

const btn_login = document.querySelector("[data-btn-login]");
btn_login.addEventListener("click", (e) => {
  e.preventDefault();
  const email = document.querySelector("[data-email-login]"),
    password = document.querySelector("[data-password-login]");

  const user = {
    Email: email.value,
    Password: password.value,
  };
  const json = JSON.stringify(user);

  postData("https://habitme.azurewebsites.net/api/Auth/Login", json).then(
    (data) => {
      alert(data);
    }
  );
});

const postData = async (url, data) => {
  let res = await fetch(url, {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: data,
  });

  return await res.json();
};
