/*---------------------------------------------------------------------------------
Cars With X Features
---------------------------------------------------------------------------------*/
DROP PROCEDURE IF EXISTS Demo.CarWithFeature;
GO

CREATE PROCEDURE Demo.CarWithFeature
	@Feature1 INT = null,
	@Feature2 INT = null,
	@Feature3 INT = null,
	@Feature4 INT = null,
	@Feature5 INT = null,
	@Feature6 INT = null,
	@Feature7 INT = null,
	@Feature8 INT = null,
	@Feature9 INT = null,
	@Feature10 INT = null,
	@Feature11 INT = null,
	@Feature12 INT = null,
	@Feature13 INT = null,
	@Feature14 INT = null,
	@Feature15 INT = null,
	@Feature16 INT = null,
	@Feature17 INT = null,
	@Feature18 INT = null,
	@Feature19 INT = null,
	@Feature20 INT = null
AS 

SELECT C.CarId, C.Make, C.Model, C.Color, C.Milage--, CF.FeatureId
FROM Demo.Car C
	INNER JOIN Demo.CarFeature CF ON C.CarId = CF.CarId 
WHERE C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId =ISNULL( @Feature1, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature2, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature3, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature4, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature5, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature6, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature7, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature8, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature9, CF.FeatureId) )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature1, CF.FeatureId)  )
	AND C.CarId IN ( SELECT CF.CarId FROM Demo.CarFeature CF WHERE CF.FeatureId = ISNULL(@Feature20, CF.FeatureId) )
GROUP BY C.CarId, C.Make, C.Model, C.Color, C.Milage
GO

EXEC Demo.CarWithFeature 
	@Feature1 = 2,
	@Feature2 = 7,
	@Feature3 = 8;
GO