function tryUpdateContact(updateFunction){
    // get values
    let phoneNumber = document.getElementById('phone-number-input').value
    let email = document.getElementById('email-input').value
    
    // reset warnings
    let emailWarning = document.getElementById('email-warning')
    let phoneWarning = document.getElementById('phone-number-warning')
    emailWarning.classList.add('d-none')
    phoneWarning.classList.add('d-none')
    
    $.ajax({
        url: '/Contact/IsContactValid/',
        type: 'POST',
        data: {
            email: email,
            phoneNumber: phoneNumber,
        },
        success: function (data) {
            // check results
            if (data.email === '' && data.phone === ''){
                updateFunction()
            }else {
                // show error
                // email
                if (data.email !== ''){
                    emailWarning.classList.remove('d-none')
                    emailWarning.innerHTML = data.email
                }
                // phone number
                if (data.phone !== ''){
                    phoneWarning.classList.remove('d-none')
                    phoneWarning.innerHTML = data.phone
                }
                
            }
            
        },
        error: function (data) {
            showAlertModal(data)
            console.log('failed')
        }
    });
}

function updateContact(){

}

function createNewContact(){
    
}