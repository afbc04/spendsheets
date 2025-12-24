# Summary

- **Title:** Remove Monthly Service
- **Description:** Administrators can remove monthly services
- **Pre-condition:** User must be Administrator & Monthly Service must exists
- **Pos-condition:** Monthly Service is removed

# Flow

### Normal Flow

1. User initiates the delete monthly service process.
2. User selects the monthly service
3. System removes the monthly service

### Exception (3) [Monthly Service has at least 1 finished entry]

3.1. System informs action could not be performed because there is at least 1 finished entry related to the current monthly service

