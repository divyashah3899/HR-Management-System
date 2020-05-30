using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
	[OperationContract]
	void addEmployee(string fname, string lname, string contact1, string contact2, string email, string address, DateTime dob, string gender, string designation, string acard, string etype, string workexp);
	[OperationContract]
	void updateEmployee(int id,string fname, string lname, string contact1, string contact2, string email, string address, DateTime dob, string gender, string designation, string acard, string etype, string workexp);
	[OperationContract]
	void deleteEmployee(int id);
	[OperationContract]
	int totalEmployee();
	[OperationContract]
	void addProject(string name, string client, string duration, int manager, string technology, string cost);
	[OperationContract]
	void updateProject(int id, string name, string client, string duration, int manager, string technology, string cost);
	[OperationContract]
	void deleteProject(int id);
	[OperationContract]
	void setLeaveStatus(int id, string status);
	[OperationContract]
	void applyLeave(int id, string fname, string ltype, DateTime sdate, DateTime edate, string reason);
	[OperationContract]
	int loginEmployee(string username, string password);
	[OperationContract]
	Employee1 showDetails(int id);

}

// Use a data contract as illustrated in the sample below to add composite types to service operations.

