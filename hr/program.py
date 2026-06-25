import hr

salary_employee = hr.SalaryEmployee(1, "John Smith", 1500)
hourly_employee = hr.HourlyEmployee(2, "Jane Doe", 40, 50)
commision_employee = hr.CommissionedEmployee(3, "Kevin Bacon", 2000, 500)

payroll_system = hr.PayrollSystem()
payroll_system.calculate_payroll(
    [salary_employee, hourly_employee, commision_employee]
)
