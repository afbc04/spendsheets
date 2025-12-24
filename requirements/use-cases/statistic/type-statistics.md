# Summary

- **Title:** Entry Type Statistics
- **Description:** System displays statistics about a certain entry type
- **Pre-condition:** -
- **Pos-condition:** Entry Type statistics are shown

# Flow

### Normal Flow

1. User initiates the entry type statistics process.
2. The system displays informations, such as:
    - Number of entries
    - Percentage related to all entries
    - Number and percentage of deleted entries
    - Number and percentage of cancelled entries _(When applied)_
    - Number and percentage of ignored entries _(When applied)_
    - Number and percentage of draft entries
    - Number and percentage of done entries
    - Number and percentage of stalled entries _(When applied)_
    - Number and percentage of scheduled entries _(When applied)_
    - Number and percentage of accomplished entries _(When applied)_
    - Number and percentage of overdue entries _(When applied)_
    - Number and percentage of pending entries _(When applied)_
    - Number and percentage of completed entries _(When applied)_
    - Number and percentage of ongoing entries _(When applied)_
    - If type is:
        - Transation:
            - Money added
            - Money removed
        - Multiple Payments:
            - Money added
            - Money removed
            - Money expected to be received
            - Money needed to be paid
            - Date of next due date _(including how many days left)_
        - Savings:
            - Money saved
            - Money spent
            - Money expected to be saved