﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WonkaBre
{
    public enum RULE_ERR_LVL
    {
        ERR_LVL_WARNING = 1,
        ERR_LVL_SEVERE,
        ERR_LVL_NONE
    }

    public enum RULE_SET_ERR_LVL
    {
        ERR_LVL_WARNING = 1,
        ERR_LVL_SEVERE,
        ERR_LVL_NONE
    }

    public enum COND_EVAL_MODE
    {
        MODE_AND = 1,
        MODE_OR,
        MODE_MAX
    }

    public enum RULE_OP
    {
        OP_NOT = 1,
        OP_AND,
        OP_OR,
        OP_NONE
    }

    public enum RULE_TYPE
    {
        RT_DOMAIN = 1,
        RT_POPULATED,
        RT_ARITH_LIMIT,
        RT_ASSIGNMENT,
        RT_DATE_LIMIT,
        RT_TRANSLATION,
        RT_COMPLEX,
        RT_PARSER,
        RT_NONE
    }

    public enum COMPLEX_RULE_ID
    {
        CRID_VALIDATE_ID = 1,
        CRID_MAX
    }

    public enum ERR_CD
    {
        CD_NOT_EXECUTED = -1,
        CD_SUCCESS,
        CD_FAILURE,
        CD_ARG_NUM_WRONG,
        CD_EXEC_ERROR,
        CD_MAX
    }

    public enum TARGET_RECORD
    {
        TRID_OF_TRANSACTION = 1,
        TRID_IN_STORAGE,
        TRID_NONE
    }
}
