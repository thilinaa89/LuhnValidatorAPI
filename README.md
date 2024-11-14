# LuhnValidatorAPI

This is a ASP.NET Web API that validates credit card numbers using the Luhn algorithm.

## API Endpoint

**GET** `/api/LuhnValidator/validate`

### Query Parameter:
- `cardNumber` (required): The credit card number to validate.

### Response:
- `Valid`: `true` if the card number is valid according to the Luhn algorithm.
- `Valid`: `false` if the card number is invalid.

## Example

**Request**:
- GET /api/LuhnValidator/validate?cardNumber=4532015112830366
