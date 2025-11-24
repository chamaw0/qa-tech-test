# Injection Flows
- SQL injection can be added to the login page and log in as a user or an Admin (Bender & Admin Login) - Vertical Privilege Escalation

# Data Exposure
- Able to guess the email addresses of the users from the 'About Us' page
- Able to see user's residential address once logged in

# Broken Access Control
- Able to log in as admin by manipulating the request

# Information Exposure
- Can see the website techstack, the tech the system was built on (JavaScript, Angular)

# Exposed Credentials (Sensitive Data Exposure)
- Hardcoded credentials can be found in the dev tools
- Email: testing@juice-sh.op Password: IamUsedForTesting

# Broken Authentication
- Admin has a weak password (admin123)
