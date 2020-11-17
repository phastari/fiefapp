import { InheritanceAlternative } from './inheritance-alternative';
import { RoadAlternative } from './road-alternative';
import { LivingconditionAlternative } from './livingcondition-alternative';

export interface ISelectionAlternatives {
  roads: RoadAlternative[];
  inheritances: InheritanceAlternative[];
  livingConditions: LivingconditionAlternative[];
}

export const initialSelectionAlternatives: ISelectionAlternatives = {
  roads: [],
  inheritances: [],
  livingConditions: [],
};
