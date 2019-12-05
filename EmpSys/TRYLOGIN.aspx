<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TRYLOGIN.aspx.cs" Inherits="EmpSys.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        .valid-feedback {
        color: forestgreen;
        }
</style>
</head>
<body>
    <<form action="/Information.aspx">
            <div class="form-row">
                <div class="col-md-4 mb-3">
                    <label for="validationServer01">First name</label>
                    <input type="text" class="form-control is-valid" id="validationServer01" placeholder="First name" value="Mark" required>
                    <div class="valid-feedback">
                        Looks good!
                    </div>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="validationServer02">Last name</label>
                    <input type="text" class="form-control is-valid" id="validationServer02" placeholder="Last name" value="Otto" required>
                    <div class="valid-feedback">
                        Looks good!
                    </div>
                </div>
                <div class="col-md-4 mb-3">
                    <label for="validationServerUsername">Username</label>
                    <div class="input-group">
                        <div class="input-group-prepend">
                            <span class="input-group-text" id="inputGroupPrepend3">@</span>
                        </div>
                        <input type="text" class="form-control is-invalid" id="validationServerUsername" placeholder="Username" aria-describedby="inputGroupPrepend3" required>
                        <div class="invalid-feedback">
                            Please choose a username.
                        </div>
                    </div>
                </div>
            </div>
            <div class="form-row">
                <div class="col-md-6 mb-3">
                    <label for="validationServer03">City</label>
                    <input type="text" class="form-control is-invalid" id="validationServer03" placeholder="City" required>
                    <div class="invalid-feedback">
                        Please provide a valid city.
                    </div>
                </div>
                <div class="col-md-3 mb-3">
                    <label for="validationServer04">State</label>
                    <input type="text" class="form-control is-invalid" id="validationServer04" placeholder="State" required>
                    <div class="invalid-feedback">
                        Please provide a valid state.
                    </div>
                </div>
                <div class="col-md-3 mb-3">
                    <label for="validationServer05">Zip</label>
                    <input type="text" class="form-control is-invalid" id="validationServer05" placeholder="Zip" required>
                    <div class="invalid-feedback">
                        Please provide a valid zip.
                    </div>
                </div>
            </div>
            <div class="form-group">
                <div class="form-check">
                    <input class="form-check-input is-invalid" type="checkbox" value="" id="invalidCheck3" required>
                    <label class="form-check-label" for="invalidCheck3">
                        Agree to terms and conditions
                    </label>
                    <div class="invalid-feedback">
                        You must agree before submitting.
                    </div>
                </div>
            </div>
            <button class="btn btn-primary" type="submit">Submit form</button>
        </form>
</body>
</html>



