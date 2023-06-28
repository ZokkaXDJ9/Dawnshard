﻿using DragaliaAPI.Shared.Definitions.Enums;

namespace DragaliaAPI.Shared.MasterAsset.Models.Shop;

public record SpecialShop(
    int Id,
    int Limit,
    PaymentTypes PaymentType,
    int NeedCost,
    int AddStaminaSingle,
    int AddStaminaMulti,
    int AddMaxDragonQuantity,
    int AddMaxWeaponQuantity,
    int AddMaxAmuletQuantity,
    int BonusGoodsType,
    int BonusGoodsQuantity,
    EntityTypes DestinationEntityType1,
    int DestinationEntityId1,
    int DestinationEntityQuantity1,
    int DestinationLimitBreakCount1,
    EntityTypes DestinationEntityType2,
    int DestinationEntityId2,
    int DestinationEntityQuantity2,
    int DestinationLimitBreakCount2,
    EntityTypes DestinationEntityType3,
    int DestinationEntityId3,
    int DestinationEntityQuantity3,
    int DestinationLimitBreakCount3,
    EntityTypes DestinationEntityType4,
    int DestinationEntityId4,
    int DestinationEntityQuantity4,
    int DestinationLimitBreakCount4,
    EntityTypes DestinationEntityType5,
    int DestinationEntityId5,
    int DestinationEntityQuantity5,
    int DestinationLimitBreakCount5,
    EntityTypes DestinationEntityType6,
    int DestinationEntityId6,
    int DestinationEntityQuantity6,
    int DestinationLimitBreakCount6,
    EntityTypes DestinationEntityType7,
    int DestinationEntityId7,
    int DestinationEntityQuantity7,
    int DestinationLimitBreakCount7,
    EntityTypes DestinationEntityType8,
    int DestinationEntityId8,
    int DestinationEntityQuantity8,
    int DestinationLimitBreakCount8
) : IShop;
