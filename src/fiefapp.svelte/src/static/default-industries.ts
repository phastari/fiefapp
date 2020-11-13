import type { Industry } from '../models/industries/industry';
import { Income, IncomeType } from '../models/industries/income';
import { Tax, TaxType } from '../models/industries/tax';
import { Link, LinkType } from '../models/industries/link';

export const getDefaultIndustries = (
  fiefId: string,
  marketId: string
): Industry[] => {
  const industries: Industry[] = [];
  // GET MODIFIERS FROM A SETTINGS FILE

  industries.push(new Link(LinkType.FIEF, fiefId));
  industries.push(new Link(LinkType.MARKET, marketId));

  industries.push(new Income(IncomeType.AGRICULTURAL, 1, 1.25, 1, 0.25));
  industries.push(new Income(IncomeType.ANIMAL_HUSBANDRY, 0.2, 0.2, 0.2, 0.2));
  industries.push(new Income(IncomeType.FISHING, 0.3, 0.3, 0.3, 0.3));
  industries.push(new Income(IncomeType.HUNTING, 0.15, 0.15, 0.15, 0.15));

  industries.push(new Tax(TaxType.AVERCORN));
  industries.push(new Tax(TaxType.LICENCE_FEE));
  industries.push(new Tax(TaxType.TAX));
  industries.push(new Tax(TaxType.TOLL));

  return industries;
};
