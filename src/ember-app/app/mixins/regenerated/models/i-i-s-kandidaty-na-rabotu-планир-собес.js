import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  время: DS.attr('string'),
  датаПланСобес: DS.attr('date'),
  иметьПриСебе: DS.attr('string'),
  организация: DS.belongsTo('i-i-s-kandidaty-na-rabotu-организация', { inverse: null, async: false }),
  регистАнкеты: DS.belongsTo('i-i-s-kandidaty-na-rabotu-регист-анкеты', { inverse: null, async: false })
});

export let ValidationRules = {
  время: {
    descriptionKey: 'models.i-i-s-kandidaty-na-rabotu-планир-собес.validations.время.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  датаПланСобес: {
    descriptionKey: 'models.i-i-s-kandidaty-na-rabotu-планир-собес.validations.датаПланСобес.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  иметьПриСебе: {
    descriptionKey: 'models.i-i-s-kandidaty-na-rabotu-планир-собес.validations.иметьПриСебе.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  организация: {
    descriptionKey: 'models.i-i-s-kandidaty-na-rabotu-планир-собес.validations.организация.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  регистАнкеты: {
    descriptionKey: 'models.i-i-s-kandidaty-na-rabotu-планир-собес.validations.регистАнкеты.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ПланирСобесE', 'i-i-s-kandidaty-na-rabotu-планир-собес', {
    датаПланСобес: attr('Дата планирования собеседования', { index: 0 }),
    время: attr('Время собеседования', { index: 1 }),
    регистАнкеты: belongsTo('i-i-s-kandidaty-na-rabotu-регист-анкеты', 'ФИО кандидата', {
      фИОКандид: attr('ФИО кандидата', { index: 3, hidden: true }),
      вакантДолжн: belongsTo('i-i-s-kandidaty-na-rabotu-вакант-должн', '', {
        должность: attr('Вакантная должность', { index: 4 })
      }, { index: -1, hidden: true }),
      номерТелефона: attr('Номер телефона кандидата', { index: 6 }),
      элПочта: attr('Электронная почта', { index: 7 }),
      организация: belongsTo('i-i-s-kandidaty-na-rabotu-организация', '', {
        адрес: attr('Адрес организации', { index: 10 }),
        телОрганиз: attr('Телефон организации', { index: 11 })
      }, { index: -1, hidden: true })
    }, { index: 2, displayMemberPath: 'фИОКандид' }),
    иметьПриСебе: attr('Иметь при себе', { index: 5 }),
    организация: belongsTo('i-i-s-kandidaty-na-rabotu-организация', 'Наименование организации', {
      наименование: attr('Наименование организации', { index: 9, hidden: true })
    }, { index: 8, displayMemberPath: 'наименование' })
  });

  modelClass.defineProjection('ПланирСобесL', 'i-i-s-kandidaty-na-rabotu-планир-собес', {
    датаПланСобес: attr('Дата планирования собеседования', { index: 0 }),
    время: attr('Время собеседования', { index: 1 }),
    регистАнкеты: belongsTo('i-i-s-kandidaty-na-rabotu-регист-анкеты', 'ФИО кандидата', {
      фИОКандид: attr('ФИО кандидата', { index: 2 }),
      вакантДолжн: belongsTo('i-i-s-kandidaty-na-rabotu-вакант-должн', '', {
        должность: attr('Вакантная должность', { index: 3 })
      }, { index: -1, hidden: true }),
      номерТелефона: attr('Номер телефона кандидата', { index: 5 }),
      элПочта: attr('Электронная почта', { index: 6 }),
      организация: belongsTo('i-i-s-kandidaty-na-rabotu-организация', '', {
        адрес: attr('Адрес организации', { index: 8 }),
        телОрганиз: attr('Телефон организации', { index: 9 })
      }, { index: -1, hidden: true })
    }, { index: -1, hidden: true }),
    иметьПриСебе: attr('Иметь при себе', { index: 4 }),
    организация: belongsTo('i-i-s-kandidaty-na-rabotu-организация', 'Наименование организации', {
      наименование: attr('Наименование организации', { index: 7 })
    }, { index: -1, hidden: true })
  });
};
