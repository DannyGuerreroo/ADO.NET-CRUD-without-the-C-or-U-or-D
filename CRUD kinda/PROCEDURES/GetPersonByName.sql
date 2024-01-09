CREATE PROCEDURE GetPersonByName
@BusinessEntityID INT
AS
  SELECT P.*, PP.PhoneNumber, PNT.Name AS PhoneName, EA.EmailAddress,
  AT.Name AS AddressName, A.AddressLine1, A.AddressLine2, A.City, A.PostalCode,
  SP.Name AS StateName, CR.Name AS CountryName, CT.Name AS ContactTypeName

  FROM Person.Person P
  
  LEFT JOIN Person.PersonPhone PP ON P.BusinessEntityID = PP.BusinessEntityID
  LEFT JOIN Person.PhoneNumberType PNT ON PP.PhoneNumberTypeID = PNT.PhoneNumberTypeID
  LEFT JOIN Person.EmailAddress EA ON P.BusinessEntityID = EA.BusinessEntityID
  LEFT JOIN Person.BusinessEntityAddress BEA ON P.BusinessEntityID = BEA.BusinessEntityID
  LEFT JOIN Person.Address A ON BEA.AddressID = A.AddressID
  LEFT JOIN Person.AddressType AT ON BEA.AddressTypeID = AT.AddressTypeID
  LEFT JOIN Person.StateProvince SP ON A.StateProvinceID = SP.StateProvinceID
  LEFT JOIN Person.CountryRegion CR ON SP.CountryRegionCode = CR.CountryRegionCode
  LEFT JOIN Person.BusinessEntityContact BEC ON P.BusinessEntityID = BEC.BusinessEntityID
  LEFT JOIN Person.ContactType CT ON BEC.ContactTypeID = CT.ContactTypeID

  WHERE P.BusinessEntityID = @BusinessEntityID;