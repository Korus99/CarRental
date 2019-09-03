CREATE PROCEDURE [dbo].[RemovedVehicles]
AS
   DELETE a
   FROM Availability a
   INNER JOIN Vehicle v
     ON a.VehicleID=v.Id
   WHERE v.Removed = 1

   DELETE m
   FROM Maintenance m
   INNER JOIN Vehicle v
     ON m.VehicleID=v.Id
   WHERE v.Removed = 1

   DELETE ms
   FROM MaintenanceSchedule ms
   INNER JOIN Vehicle v
     ON ms.VehicleID=v.Id
   WHERE v.Removed = 1

   DELETE v
   FROM Vehicle v
   WHERE v.Removed = 1
RETURN 0
