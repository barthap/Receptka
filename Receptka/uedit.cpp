#include "stdafx.h"
#include "uedit.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CMyEdit

CMyEdit::CMyEdit()
{
}

CMyEdit::~CMyEdit()
{
}


BEGIN_MESSAGE_MAP(CMyEdit, CEdit)
    //{{AFX_MSG_MAP(CMyEdit)
    //}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CMyEdit message handlers
BOOL CMyEdit::PreTranslateMessage(MSG* pMsg)
{
 // TODO: Add your specialized code here and/or call the base class
 if (pMsg->message == WM_CHAR)
 {
  int start, end;
  GetSel(start, end);

  if (start == 0)
  pMsg->wParam = toupper(pMsg->wParam);
 }

 return CEdit::PreTranslateMessage(pMsg);
}