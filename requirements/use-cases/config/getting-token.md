# Summary

- **Title:** Getting token
- **Description:** Users can obtain tokens to use the system
- **Pre-condition:** Config must exist
- **Pos-condition:** Token is obtained

# Flow

### Normal Flow

1. User indicates he wants to obtain a token
2. User provides some informations, such as:
    - Username
    - Password
3. System validates the information
4. System creates a token _(writer mode)_ and provides to user

### Exception (3) [Incorrect credentials]

3.1. System informs the credentials are incorrect, so it cant provide a token
