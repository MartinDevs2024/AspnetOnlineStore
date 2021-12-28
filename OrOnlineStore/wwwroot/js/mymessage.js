let submitForm = document.querySelector("#signupform");
submitForm.addEventListener("submit", submitData);

function submitData(e) {
    e.preventDefault();

    //Get values
    let name, email, message;
    name = document.getElementById("Name").value;
    email = document.getElementById("Email").value;
    phone= document.getElementById("PhoneNumber").value;
    message = document.getElementById("Message").value;

    if (name === "") {
        alert("Please enter your name !!!");
        return false;
    };
    if (email === "") {
        alert("Please enter your email !!!");
        return false;
    };
    if (phone ==="") {
        alert("Please enter your PhoneNumber !!!");
        return false;
    };
    if (message === "") {
        alert("Please enter your Message !!!");
        return false;
    };

    fetch('/UI/MyMessages/Create', {
        method: 'POST',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ name: name, email: email,phoneNumber: phone, message: message })
    }).then((res) => res.json())
        .then((data) => {
            submitForm.reset();
            toastr.success('Message Send');
            
        })
        .catch((error) => {
            console.error('Error', error);
        })

}