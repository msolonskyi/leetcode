import pandas as pd

def nth_highest_salary(employee: pd.DataFrame, N: int) -> pd.DataFrame:
    RETURN_COLUMN_NAME = 'Nth Highest Salary'
    sorted_salaries = employee['salary'].drop_duplicates().sort_values(ascending=False)
    if N > len(sorted_salaries):
        return pd.DataFrame({RETURN_COLUMN_NAME: [None]})
    return pd.DataFrame({RETURN_COLUMN_NAME: [sorted_salaries.iloc[N - 1]]})