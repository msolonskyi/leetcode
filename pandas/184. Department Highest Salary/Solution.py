import pandas as pd

def department_highest_salary(employee: pd.DataFrame, department: pd.DataFrame) -> pd.DataFrame:
    RETURN_COLUMN_LIST = ['Department', 'Employee', 'Salary']
    if employee.empty or department.empty:
        return pd.DataFrame(columns=RETURN_COLUMN_LIST)
    
    merged_df = employee.merge(department, left_on='departmentId', right_on='id', suffixes=('_employee', '_department'))
    highest_salary_df = merged_df.groupby('departmentId').apply(lambda x: x[x['salary'] == x['salary'].max()])
    result_df = highest_salary_df[['name_department', 'name_employee', 'salary']]
    result_df.columns = RETURN_COLUMN_LIST
    
    return result_df