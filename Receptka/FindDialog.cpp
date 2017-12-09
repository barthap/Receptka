// FindDialog.cpp : implementation file
//

#include "stdafx.h"
#include "Receptka.h"
#include "FindDialog.h"
#include "afxdialogex.h"


// CFindDialog dialog

IMPLEMENT_DYNAMIC(CFindDialog, CDialogEx)

CFindDialog::CFindDialog(CWnd* pParent /*=NULL*/)
	: CDialogEx(CFindDialog::IDD, pParent)
{

}

CFindDialog::~CFindDialog()
{
}

void CFindDialog::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Text(pDX, IDC_FIND, m_oFind);
}


BEGIN_MESSAGE_MAP(CFindDialog, CDialogEx)
END_MESSAGE_MAP()


// CFindDialog message handlers
