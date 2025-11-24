# Testing Approach for Registration Wizard

## Overview
This file outlines the registration process for customers and administrators

## Objective
- Verify that the registration wizard functions correctly for both customers and administrators, meeting all business requirements
- Ensure that the page does not reload while the user navigates through the page

## Test Scope
- Uniques registration ID generation
- State = draft at initiation
- Navigation: 'Next' button progresses steps, no 'Back' button
- Input validation at each step (email, password, service plan)
- Submission and confirmation display, including full details of steps submitted and submission status

## Test Scenarios

### Customer Registration
- Enter valid and invalid emails
- Select each service plan option; and attempt to proceed without selecting any
- Enter valid and invalid passwords (as per password requirements specified)

### Administratior Registration
- Enter valid and invalid emails
- Enter valid and invalid passwords (as per password requirements specified)

### E2E
- Confirm unique registration ID is created as per new user
- Validate draft status persists if Wizard is abandoned midway
- Validate all summary data and status display on confirmation screen
- Try nagivating out of sequence or skipping steps
- Try duplicate email addresses (customer or administrator already exists in the system)

## Test Data
- Multiple valid and invalid email addresses
- Servive plan options
- Password edge cases

## Non-functional
- Page load time / responsiveness of the qizard
- Accessibility
- Security
