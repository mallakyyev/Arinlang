"use strict";

exports.default = void 0;

var _query = _interopRequireDefault(require("../../../data/query"));

var _errors = _interopRequireDefault(require("../../../core/errors"));

var _timezones_data = _interopRequireDefault(require("./timezones_data"));

var _math = require("../../../core/utils/math");

function _interopRequireDefault(obj) { return obj && obj.__esModule ? obj : { default: obj }; }

var timeZoneDataUtils = {
  _timeZones: _timezones_data.default.zones,
  getDisplayedTimeZones: function getDisplayedTimeZones(timestamp) {
    var _this = this;

    var timeZones = this._timeZones.map(function (timezone) {
      var offset = _this.getUtcOffset(timezone.offsets, timezone.offsetIndices, timezone.untils, timestamp);

      var title = "(GMT ".concat(_this.formatOffset(offset), ") ").concat(_this.formatId(timezone.id));
      return {
        offset: offset,
        title: title,
        id: timezone.id
      };
    });

    return (0, _query.default)(timeZones).sortBy('offset').toArray();
  },
  formatOffset: function formatOffset(offset) {
    var hours = Math.floor(offset);
    var minutesInDecimal = offset - hours;
    var signString = (0, _math.sign)(offset) >= 0 ? '+' : '-';
    var hoursString = "0".concat(Math.abs(hours)).slice(-2);
    var minutesString = minutesInDecimal > 0 ? ":".concat(minutesInDecimal * 60) : ':00';
    return signString + hoursString + minutesString;
  },
  formatId: function formatId(id) {
    return id.split('/').join(' - ').split('_').join(' ');
  },
  getTimezoneById: function getTimezoneById(id) {
    var result;
    var i = 0;
    var tzList = this._timeZones;

    if (id) {
      while (!result) {
        if (!tzList[i]) {
          _errors.default.log('W0009', id);

          return;
        }

        var currentId = tzList[i]['id'];

        if (currentId === id) {
          result = tzList[i];
        }

        i++;
      }
    }

    return result;
  },
  getTimeZoneOffsetById: function getTimeZoneOffsetById(id, timestamp) {
    var tz = this.getTimezoneById(id);
    var offsets;
    var offsetIndices;
    var untils;
    var result;

    if (tz) {
      offsets = tz.offsets;
      untils = tz.untils;
      offsetIndices = tz.offsetIndices;
      result = this.getUtcOffset(offsets, offsetIndices, untils, timestamp);
    }

    return result;
  },
  getUtcOffset: function getUtcOffset(offsets, offsetIndices, untils, dateTimeStamp) {
    var index = 0;
    var offsetIndicesList = offsetIndices.split('');
    var offsetsList = offsets.split('|');
    var untilsList = untils.split('|').map(function (until) {
      if (until === 'Infinity') {
        return null;
      }

      return parseInt(until, 36) * 1000;
    });
    var currentUntil = 0;

    for (var i = 0, listLength = untilsList.length; i < listLength; i++) {
      currentUntil += untilsList[i];

      if (dateTimeStamp >= currentUntil) {
        index = i;
        continue;
      } else {
        break;
      }
    }

    if (untilsList[index + 1]) {
      index++;
    }

    var offset = Number(offsetsList[Number(offsetIndicesList[index])]);
    return -offset / 60 || offset;
  }
};
var _default = timeZoneDataUtils;
exports.default = _default;
module.exports = exports.default;