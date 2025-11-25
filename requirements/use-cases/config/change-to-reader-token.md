# Summary

- **Title:** Change writability of token
- **Description:** Users can switch writability of token
- **Pre-condition:** Token must exists
- **Pos-condition:** Token writability is changed

# Flow

### Normal Flow

1. User indicates he wants to change writability of token
2. User need to provide this information to change token to writable:
    - Username
    - Password
3. System validates the information
4. System changes the token to writable

### Alternative Flow (2) [User wants to change token to readable]

2.1. System changes the token to readable

### Exception (3) [Incorrect information]

3.1. System informs the token writability cannot be changed
